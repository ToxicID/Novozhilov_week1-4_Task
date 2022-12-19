using System;
using System.Runtime.InteropServices;

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
    //Двухмерный индексатор
    public double this[int n, int m]
    {
        get { return DoubleArray[n][m]; }
    }
    //Перегруженный оператор позволяющий увеличить значение всех элементов на 1
    public static MyNewClass operator ++(MyNewClass myNewClass)
    {
        for (int i = 0; i < myNewClass.DoubleArray.Length; i++)
        {
            for (int j = 0; j < myNewClass.DoubleArray[i].Length; j++)
            {
                myNewClass.DoubleArray[i][j] += 1;
            }

        }
        return myNewClass;
    }
    //Перегруженный оператор позволяющий уменьшить значение всех элементов на 1
    public static MyNewClass operator --(MyNewClass myNewClass)
    {
        for (int i = 0; i < myNewClass.DoubleArray.Length; i++)
        {
            for (int j = 0; j < myNewClass.DoubleArray[i].Length; j++)
            {
                myNewClass.DoubleArray[i][j] -= 1;
            }

        }
        return myNewClass;
    }
    //констант true и false:
    //обращение к экземпляру класса дает значение true, если каждая строка массива упорядоченна по возрастанию,
    ///иначе false.
    public static bool operator true(MyNewClass myNewClass)
    {
        int res = 0;
        for (int r = 0; r < myNewClass.DoubleArray.Length; r++)
        {
            for (int i = 0; i < myNewClass.DoubleArray[r].Length; i++)
            {
                for (int j = 0; j < myNewClass.DoubleArray[r].Length - 1; j++)
                {
                    if (myNewClass.DoubleArray[r][j] < myNewClass.DoubleArray[r][j + 1])
                    {

                        res++;
                    }
                }
            }
        }
        if (res == 0)
            return true;
        else return false;
    }

    //констант true и false:
    //обращение к экземпляру класса дает значение true, если каждая строка массива упорядоченна по возрастанию,
    ///иначе false.
    public static bool operator false(MyNewClass myNewClass)
    {
        int res = 0;
        for (int r = 0; r < myNewClass.DoubleArray.GetLength(0); r++)
        {
            for (int i = 0; i < myNewClass.DoubleArray.GetLength(1); i++)
            {
                for (int j = 0; j < myNewClass.DoubleArray.GetLength(1) - 1; j++)
                {
                    if (myNewClass.DoubleArray[r][j] < myNewClass.DoubleArray[r][j + 1])
                    {

                        res++;
                    }
                }
            }
        }
        if (res != 0)
            return false;
        else return true;
    }
    public static MyNewClass operator *(MyNewClass A, MyNewClass B)
    {
        int a;
        int b;

        do
        {
            if (A.n == B.n && A.m == B.m)
            {
                a = A.n;
                b = A.m;
            }
            else
            {
                Console.WriteLine("Массивы не одинакого размера\nПовторите снова");
                do
                {
                    Console.WriteLine("Введите количество строк: ");
                    if (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
                    {
                        Console.Write("Произошла ошибка. Попробуйте ещё раз.\n");
                        continue;
                    }
                    else break;
                } while (true);

                do
                {
                    Console.WriteLine("Введите количество столбцов.");
                    if (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
                    {
                        Console.Write("Произошла ошибка. Попробуйте ещё раз.\n");
                        continue;
                    }
                    else break;
                } while (true);

                B = new MyNewClass(a, b);
                continue;
            }
            break;
        } while (true);
        MyNewClass array = new MyNewClass(a, b);
        Console.WriteLine("Заполнение:");
        B = new MyNewClass(a, b);
        B.FillingTheArray();
        for (int i = 0; i < array.DoubleArray.Length; i++)
        {
            array.DoubleArray[i] = new double[array.m];
            for (int j = 0; j < array.DoubleArray[i].Length; j++)
            {
                    for (int k = 0; k < array.DoubleArray[i].Length; k++)
                    {
                        array.DoubleArray[i][j] += A[i, k] * B[k, j];
                    }

            }
        }
        Console.WriteLine("\nМассив:\n");
        array.Print();
        return array;
    }
    //Преобразования в двухмерный массив (неявное преобразование)
    public static implicit operator MyNewClass(double[][] mx)
    {
        return new MyNewClass(mx);

    }
    //Преобразования в ступенчатый массив (явное преобразование)
    public static explicit operator double[][](MyNewClass mx)
    {
        return mx.DoubleArray;
    }
    //Заполнение двухмерного массива исходя из уже заполненного ступенчатого
    public MyNewClass(double[][] mx)
    {
        DoubleArray = new double[mx.Length][];
        for (int i = 0; i < mx.Length; ++i)
        {
            DoubleArray[i] = new double[mx[i].Length];
            for (int j = 0; j < mx[i].Length; ++j)
            {
                DoubleArray[i][j] = mx[i][j];
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
        "6.Обратиться к конкретному элементу\n" +
        "7.Увеличить все элементы массива на 1\n" +
        "8.Уменьшить все элементы массива на 1\n" +
        "9.Получить информацию отсорирован массив или нет(константа true)\n" +
        "10.Получить информацию отсорирован массив или нет(константа false)\n" +
        "11.Перемножить массивы\n" +
        "12.Преобразовать массив в двухмерный\n" +
        "13.Преобразовать массив в ступенчатый\n" +
        "14.Выход\n");

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
                if (!double.TryParse(Console.ReadLine(), out scalar) || scalar <= 0)
                {
                    Console.Write("Произошла ошибка. Попробуйте ещё раз.");
                    continue;
                }
                else break;
            } while (true);
            newClass.ZoomScalar = scalar;
            Console.WriteLine("Все элементы увеличины на скаляр");
            break;
        case 6:
            int row, col;
            do
            {
                do
                {
                    Console.Write("Введите номер строки: ");
                    if (!int.TryParse(Console.ReadLine(), out row) || row <= -1)
                    {
                        Console.WriteLine("Ошибка, попробуйте ещё раз");
                        continue;
                    }
                    break;
                } while (true);

                do
                {
                    Console.Write("Введите номер столбца: ");
                    if (!int.TryParse(Console.ReadLine(), out col) || col <= -1)
                    {
                        Console.Write("Ошибка, попробуйте ещё раз");
                        continue;
                    }
                    break;
                } while (true);



                break;
            } while (true);
            try
            {
                Console.WriteLine($"Элемент под индексом [{row},{col}]: " + newClass[row, col]);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка.Повторите ввод заново");
                continue;
            }
            break;
        case 7:
            Console.WriteLine("Все элементы увеличены на 1\n");
            newClass++;
            Console.WriteLine("Массив:");
            newClass.Print();
            break;
        case 8:
            Console.WriteLine("Все элементы уменьшены на 1\n");
            newClass--;
            Console.WriteLine("Массив:");
            newClass.Print();
            break;
        case 9:
        case 10:

            if (newClass) Console.WriteLine("Строки массива упорядочены по возростаню.");
            else
                Console.WriteLine("Строки массива не упорядочены по возростанию.");

            break;

        case 11:
            Console.Write("Перемножить массивы\n");
            int a, b;
            do
            {
                Console.WriteLine("Введите количество строк: ");
                if (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
                {
                    Console.Write("Произошла ошибка. Попробуйте ещё раз.\n");
                    continue;
                }
                else break;
            } while (true);

            do
            {
                Console.WriteLine("Введите количество столбцов.");
                if (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
                {
                    Console.Write("Произошла ошибка. Попробуйте ещё раз.\n");
                    continue;
                }
                else break;
            } while (true);

            MyNewClass myNewClass = new MyNewClass(a, b);

            newClass *= myNewClass;

            break;

        case 12:
            MyNewClass array = newClass;
            Console.WriteLine("Массив преобразованный в двухмерный");
            array.Print();
            break;

        case 13:
            MyNewClass array1 = (double[][])newClass;
            Console.WriteLine("Массив преобразованный в ступенчатый");
            array1.Print();
            break;
    }
} while (res != 14);
Console.WriteLine("Было приятно с вами работать. Удачи, возвращайся.");

    }
}
}

}