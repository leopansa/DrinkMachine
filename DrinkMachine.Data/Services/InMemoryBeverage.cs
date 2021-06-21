using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkMachine.Data.Models;
using DrinkMachine.Data.Services;

namespace DrinkMachine.Data
{
    public class InMemoryBeverage : IBeverageMachineData
    {
        List<BeverageMachine> Beverages;
        
        public InMemoryBeverage()
        {
            Beverages = new List<BeverageMachine>()
            {
                new BeverageMachine{ Id=1, Name = BeverageType.Coke, Price = 25, Amount = 0},
                new BeverageMachine{ Id=2, Name = BeverageType.Pepsi, Price = 36, Amount = 0},
                new BeverageMachine{ Id=3, Name = BeverageType.Soda, Price = 45, Amount = 0}
            };

        }

        public IEnumerable<BeverageMachine> GetAll()
        {
            return Beverages;
        }

        public BeverageMachine Get(int id)
        {
            return Beverages.FirstOrDefault(b => b.Id == id);
        }

        public int GetId(BeverageType tBeverage)
        {
            BeverageMachine beverageFound = Beverages.FirstOrDefault(b => b.Name == tBeverage);
            if (beverageFound != null)
            {
                return beverageFound.Id;
            }
            else
            {
                return -1;
            }
            
        }

        public decimal GetPrice(BeverageType tBeverage)
        {
            BeverageMachine beverageFound = Beverages.FirstOrDefault(b => b.Name == tBeverage);
            if (beverageFound != null)
            {
                return beverageFound.Price;
            }
            else
            {
                return -1;
            }
        }
    }
}
