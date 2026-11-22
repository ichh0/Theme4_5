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
                Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                Console.WriteLine($"Сообщение: {ex.Message}");
                Console.WriteLine($"Метод, где произошла ошибка: {ex.TargetSite}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка: Введено не число.");
                Console.WriteLine($"Сообщение: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Блок finally выполнен. Завершение работы программы.");
            }
        }
    }
}