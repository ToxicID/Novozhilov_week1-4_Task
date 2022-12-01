using System;

namespace Новожилов_неделя1_задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            Console.Write("x=");
            while (true)
            {
                if (!float.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Ошибка при вводе данных.Попробуйте ещё раз.\nx=");
                    continue;
                }
                else break;
            }
            Console.Write("y=");
            while (true)
            {
                if (!float.TryParse(Console.ReadLine(), out y))
                {
                    Console.Write("Ошибка при вводе данных.Попробуйте ещё раз.\ny=");
                    continue;
                }
                else break;
            }

            if (y <= -Math.Abs(x) && x * x + y * y <= 625)
            {
                if (y < -Math.Abs(x) && x * x + y * y < 625)
                    Console.WriteLine("Да");
                else
                    Console.WriteLine("На границе");
            }
            else
                Console.WriteLine("Нет");

            
        }
    }
}
