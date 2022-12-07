using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Новожилов_неделя_2__задание_5
{
    class Program
    {
        static double f(double x)
        {
            try
            {
                //Данное условие используется для того чтобы под корнем не было 0 или отрицательного числа
                if (x <= 0.5) throw new Exception();
                else return Math.Round(x / Math.Sqrt(2 * x - 1),5);
            }
            catch
            {
                throw;
            }

        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите начало диапозона:");
                double start = double.Parse(Console.ReadLine());

                Console.Write("Введите конец диапозона:");
                double finish = double.Parse(Console.ReadLine());

                Console.Write("Введите шаг:");
                double h = double.Parse(Console.ReadLine());

                if (start > finish) throw new Exception("Ошибка!!\nНачало диапозона не может быть больше конца диапозона.");
                else if (h <= 0) throw new Exception("Ошибка!!\nШаг не может быть отрицательным или равным 0.");

                for (double i = start; i <= finish; i += h)
                    try
                    {
                        Console.WriteLine("y({0})={1:f4}", i, f(i));
                    }
                    catch
                    {
                        Console.WriteLine("y({0})=error", i);
                    }

            }
            //Проверка на ввод чисел
            catch (FormatException)
            {
                Console.WriteLine("Неверный ввод данных. Возможно вы пытись ввести запрещённый знак, повторите попытку ещё раз.");
            }
            //при возникномении ошибки не связанной с форматом, выводим данные о ошибке указанные в скобках
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
