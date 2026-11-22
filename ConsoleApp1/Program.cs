using System;

class StringComparisonDemo
{
    static void Main()
    {
        string s1 = "Hello";
        string s2 = "Hello";
        string s3 = "hello";
        string s4 = "World";

        Console.WriteLine("=== Строки ===");
        Console.WriteLine($"s1 = \"{s1}\"");
        Console.WriteLine($"s2 = \"{s2}\"");
        Console.WriteLine($"s3 = \"{s3}\"");
        Console.WriteLine($"s4 = \"{s4}\"");

        Console.WriteLine("\n=== Compare() ===");
        Console.WriteLine($"Compare(s1, s2) = {string.Compare(s1, s2)}");
        Console.WriteLine($"Compare(s1, s4) = {string.Compare(s1, s4)}");
        Console.WriteLine($"Compare(s4, s1) = {string.Compare(s4, s1)}");
        Console.WriteLine($"Compare(s1, s3) = {string.Compare(s1, s3)}");

        Console.WriteLine("\n=== CompareOrdinal() ===");
        Console.WriteLine($"CompareOrdinal(s1, s2) = {string.CompareOrdinal(s1, s2)}");
        Console.WriteLine($"CompareOrdinal(s1, s3) = {string.CompareOrdinal(s1, s3)}");
        Console.WriteLine($"CompareOrdinal(s1, s4) = {string.CompareOrdinal(s1, s4)}");

        Console.WriteLine("\n=== Equals() ===");
        Console.WriteLine($"s1.Equals(s2) = {s1.Equals(s2)}");
        Console.WriteLine($"s1.Equals(s3) = {s1.Equals(s3)}");
        Console.WriteLine($"s1.Equals(s3, StringComparison.OrdinalIgnoreCase) = {s1.Equals(s3, StringComparison.OrdinalIgnoreCase)}");

        Console.WriteLine("\n=== Операторы == и != ===");
        Console.WriteLine($"s1 == s2: {s1 == s2}");
        Console.WriteLine($"s1 != s3: {s1 != s3}");
        Console.WriteLine($"s1 == s3: {s1 == s3}");

        Console.WriteLine("\n=== IndexOf() ===");
        Console.WriteLine($"s1.IndexOf('l') = {s1.IndexOf('l')}");
        Console.WriteLine($"s1.IndexOf(\"lo\") = {s1.IndexOf("lo")}");
        Console.WriteLine($"s1.IndexOf(\"xyz\") = {s1.IndexOf("xyz")}");

        Console.WriteLine("\n=== Contains() ===");
        Console.WriteLine($"s1.Contains(\"ell\") = {s1.Contains("ell")}");
        Console.WriteLine($"s1.Contains(\"xyz\") = {s1.Contains("xyz")}");
        Console.WriteLine($"s1.Contains('H') = {s1.Contains('H')}");
    }
}