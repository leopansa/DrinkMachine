using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkMachine.Data.Models;

namespace DrinkMachine.Data.Services
{
    public interface IMachineData
    {
        Machine GetMachine();

        void RemoveBeverage(string beverageName, int amountBeverages);

        void Payment(List<CoinMachine> paymentCoins);
    }
}
