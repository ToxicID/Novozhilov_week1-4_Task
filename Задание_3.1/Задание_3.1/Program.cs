using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Новожилов_неделя_1_задание_3
{
    class Program
    {
        static double f(double n)
        {

            return Math.Sqrt(n) + n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление (√6+6)/2 + (√13+13)/2 + (√21+21)/2");
            double res = (f(6) / 2) + (f(13) / 2) + (f(21) / 2);
            Console.WriteLine("Результат вычисления=" + Math.Round(res, 5));
            Console.ReadLine();
        }
    }
}
