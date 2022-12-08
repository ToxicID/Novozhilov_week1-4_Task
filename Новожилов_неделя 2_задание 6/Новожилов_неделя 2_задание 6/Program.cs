using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Новожилов_неделя_2_задание_6
{
    class Program
    {
        //Первая программа(одномерный массив)-------------------------------------------------------------------------------

        static int[] Input()
        {
            int n;
            do
            {
                Console.Write("Введите размерность массива:");
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("Некорректный ввод данных. Попробуйте снова");
                    continue;
                }
                break;
            }
            while (true);

            int[] array = new int[n];
            int num;
            int j = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Элемент[{j++}]= ");
                do
                {

                    if (!int.TryParse(Console.ReadLine(), out num))
                    {
                        Console.WriteLine("Некорректный ввод данных. Попробуйте снова");
                        continue;
                    }
                    else
                        break;
                }
                while (true);
                array[i] = num;
            }

            return array;
        }

        static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
        }
        static int Counting(int[] array)
        {
            int CountingNums = 0;
            foreach (int c in array)
            {
                if (c > 0 && c % 2 != 0)
                    CountingNums++;
                if (c < 0 && -c % 2 != 0)
                    CountingNums++;
            }
            return CountingNums;
        }
        static void Main(string[] args)
        {
            int[] newArray = Input();

            Print(newArray);
            Console.WriteLine($"Количество нечётных элементов в массиве равняется:{Counting(newArray)}");
            Console.ReadLine();
        }

        //Первое задание(двухмерный массив)---------------------------------------------------------------------------

        //static int[,] Input()
        //{
        //    int n, m;
        //    do
        //    {
        //        Console.Write("Введите количество строк:");
        //        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        //        {
        //            Console.WriteLine("Некорректный ввод данных. Попробуйте снова");
        //            continue;
        //        }
        //        break;
        //    }
        //    while (true);

        //    do
        //    {
        //        Console.Write("Введите количество элементов в каждой строке:");
        //        if (!int.TryParse(Console.ReadLine(), out m) || m <= 0)
        //        {
        //            Console.WriteLine("Некорректный ввод данных. Попробуйте снова");
        //            continue;
        //        }
        //        break;
        //    }
        //    while (true);
        //    int[,] array = new int[n, m];
        //    int num;

        //    int j, j1;

        //    for (int i = 0; i < n; i++)
        //    {

        //        for (int g = 0; g < m; g++)
        //        {

        //            Console.Write($"Элемент[{j = i + 1},{j1 = g + 1}]= ");
        //            do
        //            {

        //                if (!int.TryParse(Console.ReadLine(), out num))
        //                {
        //                    Console.WriteLine("Некорректный ввод данных. Попробуйте снова");
        //                    continue;
        //                }
        //                else
        //                    break;
        //            }
        //            while (true);

        //            array[i, g] = num;
        //        }


        //    }

        //    return array;
        //}

        //static void Print(int[,] array)
        //{
        //    for (int i = 0; i < array.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < array.GetLength(1); j++)
        //        {
        //            Console.Write(array[i, j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }

        //}
        //static int Counting(int[,] array)
        //{
        //    int CountingNums = 0;
        //    foreach (int c in array)
        //    {
        //        if (c > 0 && c % 2 != 0)
        //            CountingNums++;
        //        if (c < 0 && -c % 2 != 0)
        //            CountingNums++;
        //    }
        //    return CountingNums;
        //}
        //static void Main(string[] args)
        //{
        //    int[,] newArray = Input();
        //    Console.WriteLine();
        //    Console.WriteLine("Массив:");
        //    Print(newArray);
        //    Console.WriteLine($"Количество нечётных элементов в массиве равняется:{Counting(newArray)}");
        //    Console.ReadLine();
        //}

        //Второе задание---------------------------------------------------------------------------------------------

        //static double[] Input()
        //{
        //    int n;
        //    do
        //    {
        //        Console.Write("Введите размерность массива:");
        //        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        //        {
        //            Console.WriteLine("Некорректный ввод данных. Попробуйте снова");
        //            continue;
        //        }
        //        break;
        //    }
        //    while (true);

        //    double[] array = new double[n];
        //    double num;
        //    int j = 1;
        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.Write($"Элемент[{j++}]= ");
        //        do
        //        {

        //            if (!double.TryParse(Console.ReadLine(), out num))
        //            {
        //                Console.WriteLine("Некорректный ввод данных. Попробуйте снова");
        //                continue;
        //            }
        //            else
        //                break;
        //        }
        //        while (true);
        //        array[i] = num;
        //    }

        //    return array;
        //}
        //static void Print(double[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.Write(array[i] + "\t");
        //    }
        //    Console.WriteLine();
        //}
        //static int IndexOf(double[] array, double value)
        //{
        //    int s = -1;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] == value)
        //        {
        //            s = i;
        //        }
        //    }
        //    return s;
        //}
        //static double Search(double[] array)
        //{
        //    double col = array[0];

        //    for (int i = 0; i <= array.Length - 1; i++)
        //    {
        //        if (col < array[i])
        //            col = array[i];
        //    }
        //    return col;
        //}
        //static void Main()
        //{

        //    double[] array = Input();

        //    double num = Search(array);
        //    Console.WriteLine("Массив:");
        //    Print(array);
        //    Console.WriteLine($"Последний максимальный элемент:{num} его индект {IndexOf(array, num)}");
        //    Console.ReadLine();
        //}

        //Третье задание---------------------------------------------------------------------------------------------

        //static int[,] Input(out int n)
        //{

        //    do
        //    {
        //        Console.Write("Введите размерность массива:");
        //        if (!int.TryParse(Console.ReadLine(), out n) || n <= 1)
        //        {
        //            Console.WriteLine("Некорректный ввод данных. Попробуйте снова\nМинимальное число 2, поскольку массив двухмерный и если число меньше 2 то программа не имеет смысла");
        //            continue;
        //        }
        //        break;
        //    }
        //    while (true);

        //    int[,] array = new int[n, n];
        //    int num;
        //    int j, j1;
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int g = 0; g < n; g++)
        //        {
        //            Console.Write($"Элемент[{j = i + 1},{j1 = g + 1}]= ");
        //            do
        //            {

        //                if (!int.TryParse(Console.ReadLine(), out num))
        //                {
        //                    Console.WriteLine("Некорректный ввод данных. Попробуйте снова");
        //                    continue;
        //                }
        //                else
        //                    break;
        //            }
        //            while (true);

        //            array[i, g] = num;
        //        }
        //    }

        //    return array;
        //}
        //static void Print(int[,] array)
        //{
        //    for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine())
        //        for (int j = 0; j < array.GetLength(1); j++)
        //            Console.Write($"\t {array[i, j]} ");
        //}

        //static int[,] Exchange(int[,] array, int n)
        //{
        //    //Клонирование исходного массива
        //    int[,] arrayCopy = (int[,])array.Clone();
        //    if (n % 2 == 0)
        //    {
        //        for (int i = 0; i < n; i++)
        //            for (int j = 0; j < n; j++)
        //            {
        //                array[i, n / 2] = arrayCopy[i, (n / 2) - 1];
        //                array[i, (n / 2) - 1] = arrayCopy[i, (n / 2)];
        //            }
        //    }

        //    else if (n == 3 || n == 7 || n == 11 || n == 15)
        //    {
        //        for (int i = 0; i < n; i++)
        //        {
        //            for (int j = 0; j < n; j++)
        //            {
        //                array[i, 0] = arrayCopy[i, (int)Math.Round(n / 2.0) - 1];
        //                array[i, (int)Math.Round(n / 2.0) - 1] = arrayCopy[i, 0];
        //            }
        //        }
        //    }
        //    else
        //    {
        //        for (int i = 0; i < n; i++)
        //            for (int j = 0; j < n; j++)
        //            {
        //                array[i, 0] = arrayCopy[i, (int)Math.Round(n / 2.0)];
        //                array[i, (int)Math.Round(n / 2.0)] = arrayCopy[i, 0];
        //            }
        //    }

        //    return array;
        //}

        //static void Main()
        //{

        //    int[,] myArray = Input(out int n);
        //    Console.WriteLine("Исходный массив:");
        //    Print(myArray);
        //    myArray = Exchange(myArray, n);
        //    Console.WriteLine();
        //    Console.WriteLine("Изменённый массив");
        //    Print(myArray);

        //    Console.ReadLine();

        //}

        //Четвёртое задание------------------------------------------------------------------------------------------------

        //static int[][] Input(out int n)
        //{

        //    do
        //    {
        //        Console.Write("Введите размерность массива:");
        //        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        //        {
        //            Console.WriteLine("Некорректный ввод данных. Попробуйте снова");
        //            continue;
        //        }
        //        break;
        //    }
        //    while (true);

        //    int[][] array = new int[n][];
        //    int num;
        //    int j1 = 1;
        //    for (int j = 0; j < n; j++)
        //    {
        //        array[j] = new int[n];
        //        for (int i = 0; i < n; i++)
        //        {
        //            Console.Write($"Элемент[{j1++}]= ");
        //            do
        //            {

        //                if (!int.TryParse(Console.ReadLine(), out num))
        //                {
        //                    Console.WriteLine("Некорректный ввод данных. Попробуйте снова");
        //                    continue;
        //                }
        //                else
        //                    break;
        //            }
        //            while (true);
        //            array[j][i] = num;
        //        }
        //    }

        //    return array;
        //}

        //static void Print(int[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.Write(array[i] + "\t");
        //    }
        //    Console.WriteLine();
        //}
        //static void Print(int[][] array)
        //{
        //    for (int j = 0; j < array.Length; j++)
        //    {
        //        for (int i = 0; i < array[j].Length; i++)
        //        {
        //            Console.Write(array[j][i] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //static int[] Sum(int[][] array, int n)
        //{

        //    int[] sum = new int[n];
        //    for (int j = 0; j < array.Length; j++)
        //    {
        //        int res = 0;
        //        for (int i = 0; i < array[j].Length; i++)
        //        {
        //            if (array[i][j] > 0 && array[i][j] % 2 == 0)
        //            {
        //                res += array[i][j];
        //            }

        //        }
        //        sum[j] = res;

        //    }

        //    return sum;
        //}
        //static void Main(string[] args)
        //{
        //    int[][] newArray = Input(out int n);
        //    Console.WriteLine("Ступенчатый массив");
        //    Print(newArray);
        //    int[] sum = Sum(newArray, n);
        //    Console.WriteLine("Массив с суммами");
        //    Print(sum);
        //    Console.ReadLine();
        //}
    }
}


