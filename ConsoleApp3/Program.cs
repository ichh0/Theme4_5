using System;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите делимое: ");
                int numerator = int.Parse(Console.ReadLine());

                Console.Write("Введите делитель: ");
                int denominator = int.Parse(Console.ReadLine());

                int result = numerator / denominator;
                Console.WriteLine($"Результат: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Деление на ноль: {ex.Message} (метод: {ex.TargetSite})");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Введено не число: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Работа программы завершена.");
            }
        }
    }
}