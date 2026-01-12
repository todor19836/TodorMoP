using System;

class Task8
{
    static void Main()
    {
        int[] count = new int[6];
        Random rnd = new Random();

        for (int i = 0; i < 100000; i++)
            count[rnd.Next(6)]++;

        for (int i = 0; i < 6; i++)
            Console.WriteLine($"{i + 1}: {(double)count[i] / 100000}");
    }
}
