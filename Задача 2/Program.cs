using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (m > 0 && n == 0)
            return Ackermann(m - 1, 1);
        else if (m > 0 && n > 0)
            return Ackermann(m - 1, Ackermann(m, n - 1));

        return -1; // Обработка ошибочных входных данных, если не выполнились предыдущие условия.
    }

    static void Main()
    {
        Console.Write("Введите значение m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        int result = Ackermann(n, m);

        Console.WriteLine($"A (m, n)= {result}");
    }
}
