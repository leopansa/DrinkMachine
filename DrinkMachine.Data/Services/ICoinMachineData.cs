using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkMachine.Data.Models;

namespace DrinkMachine.Data.Services
{
    public interface ICoinMachineData
    {
        IEnumerable<CoinMachine> GetAll();

        CoinMachine Get(int id);

        int GetId(string name);
    }
}
