using System;

namespace Новожилов_неделя1_задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 4
            int v;
            int l = 6;
            for (int a = 1; a <= 5; ++a, Console.WriteLine())
            {
                for (v = 6 - a; v >= 1; --v)
                {
                    Console.Write("   " + l);
                }
                l++;
            }
        }

    }
}
