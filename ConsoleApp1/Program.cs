using System;

class LoginDemo
{
    static void Main()
    {
        string[] logins = { "admin", "user", "guest", "hacker" };
        string[] passwords = { "12345", "qwerty", "pass", "letmein" };

        Console.WriteLine("Система входа");
        Console.WriteLine();

        int attempts = 3;
        int userIndex = -1;

        while (attempts > 0 && userIndex == -1)
        {
            Console.Write($"Логин (попыток: {attempts}): ");
            string login = Console.ReadLine() ?? "";

            for (int i = 0; i < logins.Length; i++)
            {
                if (string.Equals(logins[i], login, StringComparison.OrdinalIgnoreCase))
                {
                    userIndex = i;
                    break;
                }
            }

            if (userIndex == -1)
            {
                Console.WriteLine("Пользователь не найден.");
                attempts--;
            }
        }

        if (userIndex == -1)
        {
            Console.WriteLine("Попытки исчерпаны.");
            return;
        }

        bool authenticated = false;
        while (attempts > 0 && !authenticated)
        {
            Console.Write("Пароль: ");
            string password = Console.ReadLine() ?? "";

            if (string.Equals(passwords[userIndex], password, StringComparison.Ordinal))
            {
                authenticated = true;
                Console.WriteLine($"Вход выполнен: {logins[userIndex]}");
            }
            else
            {
                attempts--;
                if (attempts > 0)
                {
                    Console.WriteLine($"Неверный пароль. Осталось попыток: {attempts}.");
                    if (passwords[userIndex].Length == password.Length)
                    {
                        Console.WriteLine("Длина совпадает, проверьте регистр.");
                    }
                }
            }
        }

        if (!authenticated)
        {
            Console.WriteLine("Доступ заблокирован.");
            return;
        }

        bool running = true;
        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("1 - проверка палиндрома");
            Console.WriteLine("2 - сравнение строк");
            Console.WriteLine("0 - выход");
            Console.Write("Выбор: ");
            string choice = Console.ReadLine() ?? "";

            if (choice == "1")
            {
                Console.Write("Строка: ");
                string s = Console.ReadLine() ?? "";
                Console.WriteLine(IsPalindrome(s) ? "Палиндром." : "Не палиндром.");
            }
            else if (choice == "2")
            {
                Console.Write("Строка A: ");
                string a = Console.ReadLine() ?? "";
                Console.Write("Строка B: ");
                string b = Console.ReadLine() ?? "";

                Console.WriteLine($"Compare:         {string.Compare(a, b)}");
                Console.WriteLine($"CompareOrdinal:  {string.CompareOrdinal(a, b)}");
                Console.WriteLine($"Equals:          {a.Equals(b)}");
                Console.WriteLine($"Equals (ignore): {a.Equals(b, StringComparison.OrdinalIgnoreCase)}");
                Console.WriteLine($"==:              {a == b}");
            }
            else if (choice == "0")
            {
                running = false;
                Console.WriteLine("Сеанс завершён.");
            }
            else
            {
                Console.WriteLine("Неизвестная команда.");
            }
        }
    }

    static bool IsPalindrome(string s)
    {
        s = s.ToLower().Replace(" ", "");
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}