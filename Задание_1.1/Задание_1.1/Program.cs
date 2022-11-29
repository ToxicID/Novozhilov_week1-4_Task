using System;

namespace Новожилов_неделя_1_задание_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Первое задание с периметром по двум катетам
            while (true)
            {
                try
                {
                    Console.WriteLine("Введие первый катет");
                    var a = float.Parse(Console.ReadLine());
                    Console.WriteLine("Введие второй катет");
                    var b = float.Parse(Console.ReadLine());

                    do
                    {
                        if (a > 0 && b > 0)
                            break;
                        Console.WriteLine("Ввод данных некорректный. Повторите попытку.");

                        Console.WriteLine("Введие первый катет");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введие второй катет");
                        b = float.Parse(Console.ReadLine());
                    } while (true);
                    var P = Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) + b + a, 4);
                    Console.WriteLine("Периметр треугольника равен:{0}", P);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Произошла ошибка, попробуйте ещё раз");
                }
            }
            Console.ReadLine();
        }
    }
}
