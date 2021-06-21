using System;
using System.CodeDom;
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
            InMemoryCoinMachine memoryCoins = new InMemoryCoinMachine();

            coinsM = new List<CoinMachine>()
            {
                new CoinMachine() {Id = memoryCoins.GetId("Cent"), Name = "Cent", Amount = 100},
                new CoinMachine() {Id = memoryCoins.GetId("Penny"), Name = "Penny", Amount = 10},
                new CoinMachine() {Id = memoryCoins.GetId("Nickel"), Name = "Nickel", Amount = 5},
                new CoinMachine() {Id = memoryCoins.GetId("Quarter"), Name = "Quarter", Amount = 25},
            };


            beverageM = new List<BeverageMachine>()
            {
                new BeverageMachine()
                    {Id = memoryBeverages.GetId(BeverageType.Coke), Name = BeverageType.Coke, Amount = 5, Price = memoryBeverages.GetPrice(BeverageType.Coke)},
                new BeverageMachine()
                    {Id = memoryBeverages.GetId(BeverageType.Pepsi), Name = BeverageType.Pepsi, Amount = 15, Price = memoryBeverages.GetPrice(BeverageType.Pepsi)},
                new BeverageMachine()
                    {Id = memoryBeverages.GetId(BeverageType.Soda), Name = BeverageType.Soda, Amount = 3, Price = memoryBeverages.GetPrice(BeverageType.Soda)},
            };



            m = new Machine() {Coins = coinsM, Beverage = beverageM};
        }

        public Machine GetMachine()
        {
            return m;
        }

        public void RemoveBeverage(string beverageName, int amountBeverages)
        {
            var beverageSelected = beverageM.FirstOrDefault(b => b.Name.ToString().Equals(beverageName));
            if (beverageSelected != null)
            {
                beverageSelected.Amount = beverageSelected.Amount - amountBeverages;
            }
            
        }
        

        public void Payment(List<CoinMachine> paymentCoins)
        {
            InMemoryCoinMachine memoryCoins = new InMemoryCoinMachine();

            for (int i = 0; i < coinsM.Count; i++)
            {
                if (paymentCoins[i].Amount > 0)
                {
                    coinsM[i].Amount = coinsM[i].Amount + paymentCoins[i].Amount;
                }
            }
        }

    }
}
