using System;

namespace Новожилов_неделя_1_задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Второе задание с одинаковы ли цифры данного двухзначного числа
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите число");
                    int num = int.Parse(Console.ReadLine());
                    do
                    {
                        if (num >= -99 && num <=-10 || num>=10 && num<=99)
                        break;
                        Console.WriteLine("Вы ввели не двухзначное число!!!\nВведите другое число");
                        num = int.Parse(Console.ReadLine());
                    } while (true);



                    bool res = num % 11 == 0 ? true : false;
                    if (res)
                        Console.WriteLine("Цифры введённого числа одинаковы");
                    else
                        Console.WriteLine("Цифры введённого числа неодинаковы");
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
