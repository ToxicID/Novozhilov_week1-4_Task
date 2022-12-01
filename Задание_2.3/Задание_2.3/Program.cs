using System;

namespace Новожилов_неделя1_задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 3

            Console.Write("Введите конечное значение:");
            int n;
            int mn = 2;
            int i = 1;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.Write("Некорректный ввод. Повторите попытку." +
                        "\nВведите конечное значение:");
                    continue;
                }
                else if (n > 6 || n <= 0)
                {
                    Console.WriteLine("Некорректный ввод данных. Минимальное число 1, максимальное 6" +
                        "\nПовторите попытку");
                    continue;
                }
                else
                    break;
            }

            Console.WriteLine();


            Console.WriteLine("while");
            
            float InchInCentimeters = 2.54f;
            Console.WriteLine("Таблица перевода дюймов в сантиметры, слева дюймы, справа сантиметры");
            while (i <= n)
            {
                Console.WriteLine($"{mn}\t{mn * InchInCentimeters}");
                i++;
                mn += 2;
            }
            Console.WriteLine();
            Console.WriteLine("do...while");
            Console.WriteLine("Таблица перевода дюймов в сантиметры, слева дюймы, справа сантиметры");
            mn = 2;
            i = 1;
            do
            {

                Console.WriteLine($"{mn}\t{mn * InchInCentimeters}");
                i++;
                mn += 2;
            } while (i <= n);

            Console.WriteLine();
            Console.WriteLine("for");
            Console.WriteLine("Таблица перевода дюймов в сантиметры, слева дюймы, справа сантиметры");
            for (i = 1, mn = 2; i <= n; i++, mn += 2)
                Console.WriteLine($"{mn}\t{mn * InchInCentimeters}");

            Console.ReadLine();
        }

    }
}
