using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Новожилов_неделя_3_задание_9
{
    class Program
    {
        //Первое задание--------------------------------------------------------------------------------------

        static int[] Input(int n)
        {
            int[] array = new int[n];
            int num;
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.Write($"{i} элемент:");
                    if (!int.TryParse(Console.ReadLine(), out num))
                    {
                        Console.Write("Некорректный ввод данных, повторите попытку ещё раз\n");
                        continue;
                    }
                    else
                        break;

                } while (true);
                array[i] = num;

            }
            return array;
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Введите количество чисел в последовательности:");

                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.Write("Некорректный ввод данных, повторите попытку ещё раз\n");
                    continue;
                }
                else
                    break;
            } while (true);
            int[] array = Input(n);

            Console.Write("Введите число, исходя из которого в файл будет записываться определённые числа: ");
            int number;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
                {
                    Console.Write("Некорректный ввод данных, повторите попытку ещё раз\n");
                    continue;
                }
                else break;
            } while (true);

            FileStream f = new FileStream("text.dat", FileMode.Create);
            BinaryWriter fOut = new BinaryWriter(f);

            foreach (var s in array)
            {
                if (s % number != 0)
                    fOut.Write(s);
            }
            fOut.Close();
            f = new FileStream("text.dat", FileMode.Open);
            using (BinaryReader fIn = new BinaryReader(f))
            {

                using (StreamWriter wr = new StreamWriter(File.Open("text1.txt", FileMode.Create), Encoding.UTF8))
                {
                    while (fIn.PeekChar() > -1)
                    {
                        int num = fIn.ReadInt32();
                        wr.Write(num + " ");

                    }
                }

            }
            f.Close();

            using (StreamReader fRead = new StreamReader("text1.txt"))
            {
                string s = fRead.ReadLine();
                Console.WriteLine("Запись в файле: " + s);
            }

            Console.ReadLine();
        }

        //Второе задание--------------------------------------------------------------------------------------
        //static void Main()
        //{
        //    try
        //    {
        //        Console.Write("Введите путь к файлу: ");
        //        string fileName = Console.ReadLine();
        //        string[] lines = File.ReadAllLines(fileName);
        //        Console.WriteLine("Символ из каждой строки:");
        //        int i = 1;
        //        foreach (string line in lines)
        //        {
        //            try
        //            {
        //                if (line[0] == ' ')
        //                    Console.WriteLine($"Строка №{i}:" + "Пробел");
        //                else Console.WriteLine($"Строка №{i}:" + line[0]);
        //                i++;
        //            }
        //            catch (Exception)
        //            {
        //                Console.WriteLine($"Строка №{i}:" + "Пустая строка");
        //                i++;
        //            }
        //        }
        //        Console.ReadLine();
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Некорректный ввод пути к файлу.");
        //    }
        //}
    }
}
