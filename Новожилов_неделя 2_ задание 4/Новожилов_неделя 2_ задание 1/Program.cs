using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Новожилов_неделя_2__задание_1
{
    class Program
    {
        //Первое задание

        //static double rec(double x, int n)
        //{
        //    if (n == 0)
        //        return 1;
        //    else if (n < 0)
        //    {
        //        return 1 / Math.Pow(x, Math.Abs(n));
        //    }
        //    //Если n>0 в таком случае происходит вызов этого же метода с уменьшенной на 1 степенью
        //    return x * rec(x, n - 1);
        //}
        //static void Main(string[] args)
        //{
        //    double x;
        //    int n;
        //    do
        //    {
        //        Console.Write("Введите x=");
        //        if (!double.TryParse(Console.ReadLine(), out x) || x == 0)
        //        {
        //            Console.WriteLine("Произошла ошибка попробуй ещё раз");
        //        }
        //        else break;
        //    } while (true);

        //    do
        //    {
        //        Console.Write("Число в которое хотите возвести:");
        //        if (!int.TryParse(Console.ReadLine(), out n))
        //        {
        //            Console.WriteLine("Произошла ошибка попробуй ещё раз");
        //        }
        //        else break;
        //    } while (true);

        //    Console.WriteLine($"x = {Math.Round(rec(x, n), 5)}");
        //    Console.ReadLine();
        //}


        //Второе задание
        static void rec(int n, int kol)
        {
            if (kol > n)
                return;


            for (int i = kol; i > 0; --i)
            {
                Console.Write("  " + i);
            }
            Console.WriteLine(" ");
            rec(n, kol + 1);


        }

        static void Main()
        {
            int n;
            do
            {
                Console.Write("Введите n=");
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("Неверный ввод данных. Попробуйте ещё раз");
                }
                else break;
            } while (true);

            rec(n, 1);
            Console.ReadLine();
        }
    }
}
