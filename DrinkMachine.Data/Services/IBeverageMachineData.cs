using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkMachine.Data.Models;

namespace DrinkMachine.Data.Services
{
    public interface IBeverageMachineData
    {
        IEnumerable<BeverageMachine> GetAll();
        BeverageMachine Get(int id);
        
        int GetId(BeverageType tBeverage);
    }
}
