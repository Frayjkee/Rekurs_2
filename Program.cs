using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение m:");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение n:");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = Ackermann(m, n);

        Console.WriteLine($"Значение функции Аккермана для m={m} и n={n}: {result}");
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }

        return 0; // В данном случае это не должно произойти, так как m и n неотрицательны.
    }
}
