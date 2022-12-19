using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace абстракт7
{
    //Абстрактный класс
    abstract class Tovar
    {
        abstract public void PRINT();
        abstract public bool TYPE(string temp);
    }
    //класс игрушка
    class Toy : Tovar
    {
        string type = "Toy";
        string name;
        double price;
        string madein;
        string material;
        int age;
        public Toy(string name, double price, string madein, string material, int age)
        {
            this.name = name;
            this.price = price;
            this.madein = madein;
            this.material = material;
            this.age = age;
        }
        public override void PRINT()
        {
            Console.WriteLine("\nТип товара:" + type + "\nНазвание:" + name + "\nЦена:" + price + "\nПроизводитель:" + madein + "\nМатериал:" + material + "\nВозраст:" + age);
        }
        public override bool TYPE(string temp)
        {
            return temp.Contains(type);
        }
    }
    //Класс книга
    class Book : Tovar
    {
        string type = "Book";
        string name;
        string author;
        double price;
        string madein;
        int age;
        public Book(string name, string author, double price, string madein, int age)
        {
            this.name = name;
            this.author = author;
            this.price = price;
            this.madein = madein;
            this.age = age;
        }
        public override void PRINT()
        {
            Console.WriteLine("\nТип товара:" + type + "\nНазвание:" + name + "\nАвтор:" + author + "\nЦена:" + price + "\nИздательство:" + madein + "\nВозраст:" + age);
        }
        public override bool TYPE(string temp)
        {
            return temp.Contains(type);
        }
    }
    //Класс спорт-инвертарь
    class Sport : Tovar
    {
        string type = "Sport";
        string name;
        double price;
        string madein;
        int age;
        public Sport(string name, double price, string madein, int age)
        {
            this.name = name;
            this.price = price;
            this.madein = madein;
            this.age = age;
        }
        public override void PRINT()
        {
            Console.WriteLine("\nТип товара:" + type + "\nНазвание:" + name + "\nЦена:" + price + "\nПроизводитель:" + madein + "\nВозраст:" + age);
        }
        public override bool TYPE(string temp)
        {
            return temp.Contains(type);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string? temp;

            //Запись из файла
            string[] str1;
            int countLines = File.ReadAllLines("text.txt").Length;

            Tovar[] newObj = new Tovar[countLines];
            using (StreamReader sr = new StreamReader("text.txt"))
            {
                int i = 0;
                while (sr.Peek() > -1)
                {
                    
                        str1 = sr.ReadLine().Split(':');

                        if (str1[0] == "Toy")
                            newObj[i] = new Toy(str1[1], double.Parse(str1[2]), str1[3], str1[4], int.Parse(str1[5]));
                        else if (str1[0] == "Book")
                            newObj[i] = new Book(str1[1], str1[2], double.Parse(str1[3]), str1[4], int.Parse(str1[5]));
                        else if (str1[0] == "Sport")
                            newObj[i] = new Sport(str1[1], double.Parse(str1[2]), str1[3], int.Parse(str1[4]));

                        i++;
                    
                    
                }
            }

            Console.Write("Из файла");
            for (int i = 0; i < countLines; i++)
                newObj[i].PRINT();

            do
            {
                Console.Write("Введите тип товаров, которые нужно найти (Toy,Book,Sport), чтобы выйти stop: ");
                count = 0;
                temp = Console.ReadLine();
                for (int i = 0; i < countLines; i++)
                    if (newObj[i].TYPE(temp))
                    {
                        newObj[i].PRINT();
                        count++;
                    }

                if (temp == "stop")
                    break;
                if (count == 0)
                    Console.WriteLine("Такого типа товаров в базе нет");

            } while (true);


        }
    }
}