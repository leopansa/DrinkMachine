using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkMachine.Data.Models;

namespace DrinkMachine.Data.Services
{
    public interface ICoinData
    {
        IEnumerable<Coin> GetAll();

        Coin Get(int id);

        int GetId(CoinType name);
    }
}
