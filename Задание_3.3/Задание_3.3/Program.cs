using System;


namespace Новожилов_неделя_1_задание_3
{
    class Program
    {
        //Третье задание
        static void f(double x, out double y)
        {

            if (x < 0)
                y = -4.0;
            else if (x >= 1.0)
                y = 2.0;
            else
                y = Math.Pow(x, 2.0) + 3.0 * x + 4.0;

        }
        static double f(double x)
        {
            double y;
            if (x < 0)
                y = -4.0;
            else if (x >= 1.0)
                y = 2.0;
            else
                y = Math.Pow(x, 2.0) + 3.0 * x + 4.0;
            return y;
        }
        static void Main(string[] args)
        {
            double a, b, h;
            while (true)
            {
                Console.Write("Введите от скольки начинается диапозон: ");



                while (true)
                {
                    if (!double.TryParse(Console.ReadLine(), out a))
                    {
                        Console.Write("Некорректный ввод. Повторите попытку." +
                                                    "\nПовторите попытку:");
                        continue;
                    }
                    else
                        break;
                }

                Console.Write("Введите до скольки будет идти диапозон: ");
                while (true)
                {
                    if (!double.TryParse(Console.ReadLine(), out b))
                    {
                        Console.Write("Некорректный ввод. Повторите попытку." +
                                                    "\nПовторите попытку:");
                        continue;
                    }
                    else
                        break;
                }
                Console.Write("Введите шаг: ");
                while (true)
                {
                    if (!double.TryParse(Console.ReadLine(), out h))
                    {
                        Console.Write("Некорректный ввод. Повторите попытку." +
                                                    "\nПовторите попытку:");
                        continue;
                    }
                    else if (h <= 0)
                    {
                        Console.Write("Некорректный ввод. Повторите попытку." +
                                                   "\nПовторите попытку:");
                        continue;
                    }
                    else
                        break;
                }

                if (a > b)
                {
                    Console.WriteLine("Начало диапозона не может быть больше конца диапозона" +
                            "\nПопробуйте ещё раз");

                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Старый вариант");
            for (double i = a; i <= b; i += h)
            {
                Console.WriteLine("f({0:f2})={1:f2}", i, f(i));
            }
            Console.WriteLine();
            Console.WriteLine("Перегруженный метод");

            for (double i = a; i <= b; i += h)
            {
                f(i, out double y);
                Console.WriteLine("f({0:f2})={1:f2}", i, y);
            }
            Console.ReadLine();
        }
    }
}

