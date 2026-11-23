using System;
using System.Globalization;
using System.Text;

namespace Task4
{
    internal class Program
    {
        static void Main()
        {
            const double Bonus = 15;

            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введите сумму вклада: ");
            string input = Console.ReadLine() ?? "";

            double deposit;

            try
            {
                // Дробную часть можно отделять точкой или запятой.
                deposit = Convert.ToDouble(input.Replace(',', '.'), CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: нужно ввести число.");
                return;
            }

            if (!double.IsFinite(deposit) || deposit < 0)
            {
                Console.WriteLine("Ошибка: введите неотрицательную сумму вклада.");
                return;
            }

            int interestRate;

            if (deposit < 100)
            {
                interestRate = 5;
            }
            else if (deposit <= 200)
            {
                interestRate = 7;
            }
            else
            {
                interestRate = 10;
            }

            double interest = deposit * (interestRate / 100.0);
            double totalAmount = deposit + interest + Bonus;

            if (!double.IsFinite(totalAmount))
            {
                Console.WriteLine("Ошибка: сумма вклада слишком велика для расчёта.");
                return;
            }

            // Округляем итоговую сумму до копеек.
            totalAmount = Math.Round(totalAmount, 2, MidpointRounding.AwayFromZero);

            Console.WriteLine($"Процент по вкладу: {interestRate}%");
            Console.WriteLine($"Бонус: {Bonus:F2}");
            Console.WriteLine($"Итоговая сумма с процентами и бонусом: {totalAmount:F2}");
        }
    }
}
