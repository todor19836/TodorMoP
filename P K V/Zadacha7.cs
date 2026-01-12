using System;

class Task7
{
    static long Fact(int n) => n <= 1 ? 1 : n * Fact(n - 1);

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        long permutations = Fact(n);
        long combinations = Fact(n) / (Fact(k) * Fact(n - k));
        long variations = Fact(n) / Fact(n - k);

        Console.WriteLine($"Пермутации: {permutations}");
        Console.WriteLine($"Комбинации: {combinations}");
        Console.WriteLine($"Вариации: {variations}");
    }
}
