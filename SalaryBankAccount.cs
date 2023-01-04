using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSeventeen
{
    public class SalaryBankAccount : ICalculator
    {
        public void CalculateInterest()
        {
            // Реализация бизнесс логики обычного счёта
            Console.WriteLine("Реализация обычного счёта");

            Account account = new Account();

            if (account.Type == "Обычный")
            {
                // расчет процентной ставки обычного аккаунта по правилам банка
                account.Interest = account.Balance * 0.4;
                if (account.Balance < 1000)
                    account.Interest -= account.Balance * 0.2;

                if (account.Balance < 50000)
                    account.Interest -= account.Balance * 0.4;
            }
        }
    }
}
