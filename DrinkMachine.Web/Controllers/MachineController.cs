using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DrinkMachine.Data.Models;
using DrinkMachine.Data.Services;


namespace DrinkMachine.Web.Controllers
{
    public class MachineController : Controller
    {
        private readonly IMachineData _dbMachine;
        private readonly ICoinData _dbCoin;
        private readonly IBeverageData _dbBeverage;

        public MachineController(IMachineData mData)
        {
            this._dbMachine = mData;
        }

        // GET: Machine
        public ActionResult Index()
        {
            var model = _dbMachine.GetMachine();
            return View(model);
        }
    }
}