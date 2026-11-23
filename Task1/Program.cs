using System;
using System.Globalization;
using System.Text;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введите первое число: ");
            string firstInput = Console.ReadLine() ?? "";

            Console.Write("Введите второе число: ");
            string secondInput = Console.ReadLine() ?? "";

            // Дробную часть можно отделять точкой или запятой.
            if (!decimal.TryParse(firstInput.Replace(',', '.'), NumberStyles.Float,
                    CultureInfo.InvariantCulture, out decimal firstNumber)
                || !decimal.TryParse(secondInput.Replace(',', '.'), NumberStyles.Float,
                    CultureInfo.InvariantCulture, out decimal secondNumber))
            {
                Console.WriteLine("Ошибка: нужно ввести два числа.");
                return;
            }

            if (firstNumber == secondNumber)
            {
                Console.WriteLine("Числа равны.");
            }
            else if (firstNumber > secondNumber)
            {
                Console.WriteLine("Первое число больше второго, а второе меньше первого.");
            }
            else
            {
                Console.WriteLine("Первое число меньше второго, а второе больше первого.");
            }
        }
    }
}
