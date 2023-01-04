using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSeventeen
{
    public class SimpleBankAccount : ICalculator
    {
        public void CalculateInterest(Account account)
        {
            if (account.Type == "Зарплатный")
            {
                // расчет процентной ставк зарплатного аккаунта по правилам банка
                account.Interest = account.Balance * 0.5;
            }
        }
    }
}
