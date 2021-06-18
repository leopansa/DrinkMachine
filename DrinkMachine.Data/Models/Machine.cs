using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkMachine.Data.Models
{
    public class Machine
    {
        public List<CoinMachine> Coins { get; set; }
        public List<BeverageMachine> Beverage { get; set; }
        

        

    }
}
