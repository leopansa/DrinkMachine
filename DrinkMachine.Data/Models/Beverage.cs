using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkMachine.Data.Models
{
    public class Beverage
    {
        public int Id { get; set; }
        
        public BeverageType Name { get; set; }
        
        public decimal Price { get; set; }
    }

    
}
