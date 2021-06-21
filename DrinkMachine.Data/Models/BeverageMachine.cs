using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkMachine.Data.Models
{
    public class BeverageMachine
    {
        [Required]
        public int Id { get; set; }
        
        public BeverageType Name { get; set; }
        
        public decimal Price { get; set; }
        
        

        public int Amount { get; set; }

    }
}
