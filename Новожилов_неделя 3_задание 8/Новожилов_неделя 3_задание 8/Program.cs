using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Новожилов_неделя_3_задание_8
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложжение:");
            string text = Console.ReadLine();
            Regex regex = new Regex(@"\b[уеёыаоэяию][а-я]+\b", RegexOptions.IgnoreCase);
            // \b -начало на границе слова
            // RegexOptions.IgnoreCase - игнорирует регистр
            var result = regex.Replace(text, "");
            result = Regex.Replace(result, @"\s+", " ");
            Console.WriteLine(result);
        }
    }
}
