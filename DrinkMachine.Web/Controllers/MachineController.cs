using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DrinkMachine.Data.Models;
using DrinkMachine.Data.Services;
using DrinkMachine.Web.Models;


namespace DrinkMachine.Web.Controllers
{
    public class MachineController : Controller
    {
        private readonly IMachineData _dbMachine;
        private readonly ICoinMachineData _dbCoin;
        private readonly IBeverageMachineData _dbBeverage;

        public MachineController(IMachineData mData, ICoinMachineData mCoin, IBeverageMachineData mBeverage)
        {
            this._dbMachine = mData;
            this._dbCoin= mCoin;
            this._dbBeverage = mBeverage;
        }

        // GET: Machine
        public ActionResult Index()
        {
            var modelMachine = _dbMachine.GetMachine();
            
            var coins = _dbCoin.GetAll();
            var coinsM = _dbMachine.GetMachine().Coins;
            var beverages = _dbBeverage.GetAll();
            var beveragesM = _dbMachine.GetMachine().Beverage;

            var order = new OrderViewModel(){};
            order.Coins = coins.ToList();
            order.Beverages = beverages.ToList();
            order.BeveragesMachine = beveragesM;
            order.CoinsMachine = coinsM;

            return View(order);
        }

        [HttpPost]
        public ActionResult GetDrinks (OrderViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Total > 0)
                {
                    foreach (var botle in model.Beverages)
                    {
                        if (botle.Amount > 0)
                        {
                            _dbMachine.RemoveBeverage(botle.Name.ToString(), botle.Amount);
                            _dbMachine.Payment(model.Coins);
                        }
                    }

                    return View();
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public decimal GetValueDrink (string name, int amount)
        {
            var beveragesM = _dbMachine.GetMachine().Beverage.ToList();
            var selectedBeverage = beveragesM.FirstOrDefault(b => b.Name.ToString().Equals(name));
            if (selectedBeverage != null)
            {
                //1. Check amount of drinks inside the machine
                if (amount <= selectedBeverage.Amount)
                {
                    //2. get price 
                    return selectedBeverage.Price * amount;
                }
                else
                {
                    return 0.00M;
                }

            }
            else
            {
                return 0.00M;
            }
            
        }

    }
}