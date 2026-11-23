using System;
using System.Globalization;
using System.Text;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введите число: ");
            string input = Console.ReadLine() ?? "";

            // Дробную часть можно отделять точкой или запятой.
            if (!decimal.TryParse(input.Replace(',', '.'), NumberStyles.Float,
                    CultureInfo.InvariantCulture, out decimal number))
            {
                Console.WriteLine("Ошибка: нужно ввести число.");
                return;
            }

            // Обе границы не входят в диапазон.
            if (number > 5 && number < 10)
            {
                Console.WriteLine("Число больше 5 и меньше 10.");
            }
            else
            {
                Console.WriteLine("Число не входит в диапазон больше 5 и меньше 10.");
            }
        }
    }
}
