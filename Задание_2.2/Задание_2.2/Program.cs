using System;

namespace Новожилов_неделя1_задание2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Вторая программа


            Console.Write("Введите количество прошедших месяцев : ");
            int m;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out m))
                {
                    Console.Write("Некорректный ввод. Повторите попытку." +
                        "\nВведите количество прошедших месяцев :");
                    continue;
                }
                else if (m <= 0)
                {
                    Console.Write("Некорректный ввод. Повторите попытку." +
                        "\nВведите количество прошедших месяцев :");
                    continue;
                }
                else
                    break;
            }
            DateTime dt = new DateTime(1990, 1, 1);
            int x = dt.Month + m % 12;
            string month = "";
            switch (x)
            {

                case 1:
                    month = "Январь";
                    break;
                case 2:
                    month = "Февраль";
                    break;
                case 3:
                    month = "Март";
                    break;
                case 4:
                    month = "Апрель";
                    break;
                case 5:
                    month = "Май";
                    break;
                case 6:
                    month = "Июнь";
                    break;
                case 7:
                    month = "Июль";
                    break;
                case 8:
                    month = "Август";
                    break;
                case 9:
                    month = "Сентябрь";
                    break;
                case 10:
                    month = "Октябрь";
                    break;
                case 11:
                    month = "Ноябрь";
                    break;
                case 12:
                    month = "Декабрь";
                    break;
            }

            Console.WriteLine("Сейчас: " + month);
            Console.ReadLine();
        }

    }
}
