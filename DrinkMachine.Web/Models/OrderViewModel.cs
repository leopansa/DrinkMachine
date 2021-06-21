using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DrinkMachine.Data.Models;

namespace DrinkMachine.Web.Models
{
    public class OrderViewModel
    {
        public List<CoinMachine> Coins { get; set; }
        public List<CoinMachine> CoinsMachine { get; set; }

        public List<BeverageMachine> Beverages { get; set; }

        public List<BeverageMachine> BeveragesMachine { get; set; }
        public decimal Total{ get; set; }
    }

    public class CoinView
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        public int Amount { get; set; }
    }
}