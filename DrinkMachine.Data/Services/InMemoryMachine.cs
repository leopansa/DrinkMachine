using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkMachine.Data.Models;

namespace DrinkMachine.Data.Services
{
    public class InMemoryMachine : IMachineData
    {
        List<CoinMachine> coinsM;
        List<BeverageMachine> beverageM;
        Machine m;
        
        public InMemoryMachine()
        {

            InMemoryBeverage memoryBeverages = new InMemoryBeverage();
            InMemoryCoin memoryCoins = new InMemoryCoin();

            coinsM = new List<CoinMachine>()
            {
                new CoinMachine() {Id = memoryCoins.GetId(CoinType.Cent), Name = CoinType.Cent, Quantity = 100},
                new CoinMachine() {Id = memoryCoins.GetId(CoinType.Penny), Name = CoinType.Penny, Quantity = 10},
                new CoinMachine() {Id = memoryCoins.GetId(CoinType.Nickel), Name = CoinType.Nickel, Quantity = 5},
                new CoinMachine() {Id = memoryCoins.GetId(CoinType.Quarter), Name = CoinType.Quarter, Quantity = 25},
            };


            beverageM = new List<BeverageMachine>()
            {
                new BeverageMachine()
                    {Id = memoryBeverages.GetId(BeverageType.Coke), Name = BeverageType.Coke, Quantity = 5, Price = memoryBeverages.GetPrice(BeverageType.Coke)},
                new BeverageMachine()
                    {Id = memoryBeverages.GetId(BeverageType.Pepsi), Name = BeverageType.Pepsi, Quantity = 15, Price = memoryBeverages.GetPrice(BeverageType.Pepsi)},
                new BeverageMachine()
                    {Id = memoryBeverages.GetId(BeverageType.Soda), Name = BeverageType.Soda, Quantity = 3, Price = memoryBeverages.GetPrice(BeverageType.Soda)},
            };



            m = new Machine() {Coins = coinsM, Beverage = beverageM};
        }

        public Machine GetMachine()
        {
            return m;
        }
        
    }
}
