using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Новожилов_неделя_3_задание_10
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Directory.Exists("C:\\temp")) { Directory.Delete("C:\\temp", true); }
            else
                Directory.CreateDirectory("C:\\temp");


            Directory.CreateDirectory("C:\\temp\\K1");
            Directory.CreateDirectory("C:\\temp\\K2");
            //t1.txt
            using (StreamWriter sw = new StreamWriter("C:\\temp\\K1\\t1.txt", false))
            {
                sw.WriteLine("Новожилов Илья Александрович, 1965 года рождения, место жительства г. Саратов");
               
            }
            //t2.txt
            using (StreamWriter sw = new StreamWriter("C:\\temp\\K1\\t2.txt", false))
            {
                sw.WriteLine("Новожилов Илья Александрович, 1966 года рождения, место жительства г.Энгельс");
              
            }
            //Запись в один файл - t3.txt
            using (StreamWriter sw = new StreamWriter("C:\\temp\\K2\\t3.txt", false))
            {
                string str;
                using (StreamReader sr = new StreamReader("C:\\temp\\K1\\t1.txt"))
                {
                    str = sr.ReadToEnd();
                }
                sw.WriteLine(str);
                using (StreamReader sr = new StreamReader("C:\\temp\\K1\\t2.txt"))
                {
                    str = sr.ReadToEnd();
                }
                sw.WriteLine(str);
            }
            //Информация о файлах
            DirectoryInfo dir1 = new DirectoryInfo("C:\\temp\\K1");
            DirectoryInfo dir2 = new DirectoryInfo("C:\\temp\\K2");

            FileInfo[] info = dir1.GetFiles();
            Console.WriteLine("Информация о файлах в папке K1\n");
            foreach (FileInfo file in info)
            {
                Console.WriteLine("Путь к файлу: " + file.FullName.ToString() + '\n' +
                    "Имя файла: " + file.Name.ToString() + '\n' +
                   "Расширение файла: " + file.Extension.ToString() + '\n' +
                    "Размер файла (в байтах): " + file.Length.ToString() + '\n' +
                    "Время создания файла: " + file.CreationTime.ToString() + '\n' +
                    "Последнее время записи файла: " + file.LastWriteTime.ToString());
                Console.WriteLine("\n");
            }
            Console.WriteLine();
            FileInfo[] info2 = dir2.GetFiles();
            Console.WriteLine("\nИнформация о файлах в папке K2\n");
            foreach (FileInfo file in info2)
            {
                Console.WriteLine("Путь к файлу: " + file.FullName.ToString() + '\n' +
                    "Имя файла: " + file.Name.ToString() + '\n' +
                   "Расширение файла: " + file.Extension.ToString() + '\n' +
                    "Размер файла (в байтах): " + file.Length.ToString() + '\n' +
                    "Время создания файла: " + file.CreationTime.ToString() + '\n' +
                    "Последнее время записи файла: " + file.LastWriteTime.ToString());
                Console.WriteLine("\n");
            }
            //Перемещение
            File.Move("C:\\temp\\K1\\t2.txt", "C:\\temp\\K2\\t2.txt");
            //Копирование с перезаписью(если файл есть)
            File.Copy("C:\\temp\\K1\\t1.txt", "C:\\temp\\K2\\t1.txt", true);
            //Переменование файла K2 в ALL
            Directory.Move("C:\\temp\\K2", "C:\\temp\\ALL");
            //Удаление папки K1 и все файлы в нём
            Directory.Delete("C:\\temp\\K1", true);

            Console.WriteLine("\nИнформация в папке ALL:\n");
            DirectoryInfo dir3 = new DirectoryInfo("C:\\temp\\ALL");
            FileInfo[] info3 = dir3.GetFiles();

            foreach (FileInfo file in info3)
            {
                Console.WriteLine("Путь к файлу: " + file.FullName.ToString() + '\n' +
                    "Имя файла: " + file.Name.ToString() + '\n' +
                   "Расширение файла: " + file.Extension.ToString() + '\n' +
                    "Размер файла (в байтах): " + file.Length.ToString() + '\n' +
                    "Файл доступен только для чтения или нет (True - Только для чтения, False - для чтения и записи): " + file.IsReadOnly.ToString() + '\n' +
                    "Атрибут файла: " + file.Attributes.ToString() + '\n' +
                   "Время создания файла: " + file.CreationTime.ToString() + '\n' +
                    "Последнее время записи файла: " + file.LastWriteTime.ToString());
                Console.WriteLine("\n");
            }
            //Запуск Проводника с путём C:\\temp
            Process.Start("explorer", "C:\\temp");
            Console.ReadLine();
        }
    }
}
