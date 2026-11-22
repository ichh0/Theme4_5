using System;

namespace StringComparisonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Привет";
            string str2 = "привет";
            string str3 = "Привет";

            Console.WriteLine("--- Операторы == и != ---");
            Console.WriteLine($"str1 == str3: {str1 == str3}"); // True
            Console.WriteLine($"str1 != str2: {str1 != str2}"); // True

            Console.WriteLine("\n--- Метод Equals() ---");
            Console.WriteLine($"str1.Equals(str2): {str1.Equals(str2)}"); // False
            Console.WriteLine($"str1.Equals(str2, StringComparison.OrdinalIgnoreCase): {str1.Equals(str2, StringComparison.OrdinalIgnoreCase)}"); // True

            Console.WriteLine("\n--- Метод Compare() ---");
            Console.WriteLine($"string.Compare(str1, str3): {string.Compare(str1, str3)}"); // 0
            Console.WriteLine($"string.Compare(str1, str2): {string.Compare(str1, str2)}");

            Console.WriteLine("\n--- Метод CompareOrdinal() ---");
            Console.WriteLine($"string.CompareOrdinal(str1, str2): {string.CompareOrdinal(str1, str2)}");

            Console.WriteLine("\n--- Методы IndexOf() и Contains() ---");
            Console.WriteLine($"str1.IndexOf(\"вет\"): {str1.IndexOf("вет")}"); // 3
            Console.WriteLine($"str1.Contains(\"При\"): {str1.Contains("При")}"); // True
        }
    }
}