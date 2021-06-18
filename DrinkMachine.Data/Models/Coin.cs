using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkMachine.Data.Models
{
    public class Coin
    {
        public int Id { get; set; }
        
        public CoinType Name { get; set; }
        
    }

    
}
