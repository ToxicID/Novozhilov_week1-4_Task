using System;
using System.Text;

namespace Новожилов_неделя3_задание7
{
    class Programm
    {
        //Первое задание (Удваивает каждое вхождение заданного символа x)

        static void Main()
        {
            try
            {
                Console.Write("Введите строку:");
                string? str = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(str)) throw new Exception();
                Console.Write("Введите символ, который будет удвоен в введённой строке:");
                StringBuilder stringBuilder = new StringBuilder(str);
                string x = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(x)) throw new Exception();

                stringBuilder.Replace(x, x + x);
                string res = stringBuilder.ToString();
                Console.WriteLine();
                Console.WriteLine($"Изначально введённая строка: {str}\nИзменённая строка: {res}");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Некорретный ввод данных. Повторите попытку ещё раз.");
            }
        }

        //Второе задание (Удалить из сообщения все повторяющиеся слова (без учета регистра)

        static void Main()
        {
            try
            {
                Console.Write("Введите строку:");
                string str = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(str)) throw new Exception();
                string[] slova = str.Split(' ');
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < slova.Length; ++i)
                {
                    //Если условие истинно в строчке есть одинаковые слова вне зависимости от регистра
                    //Если равняется -1, тогда просто идёт запись в переменную sb класса StringBilder
                    //Если не равняется -1 тогда слово, не записывается
                    if (sb.ToString().ToLower().IndexOf(slova[i].ToLower()) == -1)
                        sb.Append(slova[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine($"Изменённая строка: {sb}");
            }
            catch (Exception)
            {
                Console.WriteLine("Некорретный ввод данных. Повторите попытку ещё раз.");
            }
        }
    }
}