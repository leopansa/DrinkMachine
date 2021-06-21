using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkMachine.Data.Models;

namespace DrinkMachine.Data.Services
{
    public class InMemoryCoinMachine : ICoinMachineData
    {
        List<CoinMachine> Coins;

        public InMemoryCoinMachine()
        {
                Coins = new List<CoinMachine>()
                {
                    new CoinMachine(){Id = 1, Name = "Cent" },
                    new CoinMachine(){Id = 2, Name = "Penny" },
                    new CoinMachine(){Id = 3, Name = "Nickel"},
                    new CoinMachine(){Id = 4, Name = "Quarter" },
                };
        }

        public IEnumerable<CoinMachine> GetAll()
        {
            return Coins;
        }

        public CoinMachine Get(int id)
        {
            return Coins.FirstOrDefault(c => c.Id == id);
        }

        public int GetId(string name)
        {
            CoinMachine coinFound = Coins.FirstOrDefault(c => c.Name == name);
            if (coinFound != null)
            {
                return coinFound.Id;
            }
            else
            {
                return -1;
            }
            
        }

    }
}
