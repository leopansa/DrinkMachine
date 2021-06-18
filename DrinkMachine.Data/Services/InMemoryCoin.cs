using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkMachine.Data.Models;

namespace DrinkMachine.Data.Services
{
    public class InMemoryCoin : ICoinData
    {
        List<Coin> Coins;

        public InMemoryCoin()
        {
                Coins = new List<Coin>()
                {
                    new Coin(){Id = 1, Name = CoinType.Cent},
                    new Coin(){Id = 2, Name = CoinType.Penny},
                    new Coin(){Id = 3, Name = CoinType.Nickel},
                    new Coin(){Id = 4, Name = CoinType.Quarter},
                };
        }

        public IEnumerable<Coin> GetAll()
        {
            return Coins;
        }

        public Coin Get(int id)
        {
            return Coins.FirstOrDefault(c => c.Id == id);
        }

        public int GetId(CoinType name)
        {
            Coin coinFound = Coins.FirstOrDefault(c => c.Name == name);
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
