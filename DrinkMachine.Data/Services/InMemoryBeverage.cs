using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkMachine.Data.Models;
using DrinkMachine.Data.Services;

namespace DrinkMachine.Data
{
    public class InMemoryBeverage : IBeverageData
    {
        List<Beverage> Beverages;
        
        public InMemoryBeverage()
        {
            Beverages = new List<Beverage>()
            {
                new Beverage{ Id=1, Name = BeverageType.Coke, Price = 25},
                new Beverage{ Id=2, Name = BeverageType.Pepsi, Price = 36},
                new Beverage{ Id=3, Name = BeverageType.Soda, Price = 45}
            };

        }

        public IEnumerable<Beverage> GetAll()
        {
            return Beverages;
        }

        public Beverage Get(int id)
        {
            return Beverages.FirstOrDefault(b => b.Id == id);
        }

        public int GetId(BeverageType tBeverage)
        {
            Beverage beverageFound = Beverages.FirstOrDefault(b => b.Name == tBeverage);
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
            Beverage beverageFound = Beverages.FirstOrDefault(b => b.Name == tBeverage);
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
