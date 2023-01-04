using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSeventeen
{
    public class RenderedСlass
    {
        public void DistributionMethod(ICalculator calculator)
        {
            // Выношу бизнесс логику из класса Calculator и заменяю его на класс RenderedСlass, чтобы не путаться
            calculator.CalculateInterest();
        }
    }
}
