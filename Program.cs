using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSeventeen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var resalt = new RenderedСlass();

            resalt.DistributionMethod(new SalaryBankAccount());

            Console.WriteLine();

            resalt.DistributionMethod(new SimpleBankAccount());
        }
    }
}
