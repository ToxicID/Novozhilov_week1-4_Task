using System;

namespace Новожилов_неделя_3_задание_11
{
    class MyNewClass
    {
        double[][] DoubleArray;
        int n, m;
        //Создание массива
        public MyNewClass(int rows, int cols)
        {
            n = rows;
            m = cols;
            DoubleArray = new double[n][];
        }
        //Заполнение массива
        public void FillingTheArray()
        {
            double num;
            for (int i = 0; i < DoubleArray.Length; i++)
            {
                DoubleArray[i] = new double[m];
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Введите элемент[{i},{j}]: ");
                    do
                    {
                        if (!double.TryParse(Console.ReadLine(), out num))
                        {
                            Console.Write("Произошла ошибка. Попробуйте ещё раз.");
                            continue;
                        }
                        else break;
                    } while (true);
                    DoubleArray[i][j] = num;
                }
            }
        }
        //Вывод массива на экран
        public void Print()
        {
            for (int i = 0; i < DoubleArray.Length; i++)
            {
                for (int j = 0; j < DoubleArray[i].Length; j++)
                {
                    Console.Write(DoubleArray[i][j] + "\t");
                }
                Console.WriteLine();
            }

        }
        //Сортировка массива
        public void Sort()
        {
            for (var i = 0; i < DoubleArray.Length; ++i)
            {
                Array.Sort(DoubleArray[i]);
                Array.Reverse(DoubleArray[i]);
            }
        }
        //Количество элементов
        public int CountElem
        {
            get { return n * m; }
        }
        //Увеличение на скаляр
        public double ZoomScalar
        {
            set
            {
                for (int i = 0; i < DoubleArray.Length; i++)
                {
                    for (int j = 0; j < DoubleArray[i].Length; j++)
                    {
                        DoubleArray[i][j] += value;
                    }

                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                int n, m;
                do
                {
                    Console.Write("Введите количество строк: ");
                    if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                    {
                        Console.Write("Произошла ошибка. Попробуйте ещё раз.");
                        continue;
                    }
                    else break;
                } while (true);

                do
                {
                    Console.Write("Введите количество столбцов: ");
                    if (!int.TryParse(Console.ReadLine(), out m) || m <= 0)
                    {
                        Console.Write("Произошла ошибка. Попробуйте ещё раз.");
                        continue;
                    }
                    else break;
                } while (true);

                MyNewClass newClass = new MyNewClass(n, m);
                int res;
                do
                {
                    Console.Write("\nЧто вы хотите сделать?\n" +
                        "1.Заполнить массив\n" +
                        "2.Вывести элементы массива\n" +
                        "3.Отсоритровать элементы каждой строки в порядке убывания\n" +
                        "4.Получить количество элементов в массиве\n" +
                        "5.Увеличить значение всех элементов массива на скаляр\n" +
                        "6.Выход\n");
                    Console.Write("_________________________________________\nВаш выбор: ");
                    
                    do
                    {
                        if (!int.TryParse(Console.ReadLine(), out res) || res <= 0)
                        {
                            Console.Write("Произошла ошибка. Попробуйте ещё раз.");
                            continue;
                        }
                        else break;
                    } while (true);
                    Console.WriteLine();
                    switch (res)
                    {
                        case 1:
                            newClass.FillingTheArray();
                            break;
                        case 2:
                            Console.WriteLine("Массива:");
                            newClass.Print();
                            break;
                        case 3:
                            newClass.Sort();
                            Console.WriteLine("Массива отсортирован)");
                            break;
                        case 4:
                            Console.WriteLine($"Количество элементов в массиве: {newClass.CountElem}");
                            break;
                        case 5:
                            Console.Write("Введите скаляр: ");
                            double scalar;
                            do
                            {
                                if (!double.TryParse(Console.ReadLine(), out scalar))
                                {
                                    Console.Write("Произошла ошибка. Попробуйте ещё раз.");
                                    continue;
                                }
                                else break;
                            } while (true);
                            newClass.ZoomScalar = scalar;
                            Console.WriteLine("Все элементы увеличины на скаляр");
                            break;
                       
                    }
                } while (res != 6);
                Console.WriteLine("Было приятно с вами работать. Удачи, возвращайся.");
             
            }
        }
    }
}
