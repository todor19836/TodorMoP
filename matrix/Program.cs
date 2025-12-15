using System;

class Task3
{
    static void Main()
    {
        double[,] m = new double[3, 3];

        for (int i = 0; i < 3; i++)
        {
            var row = Console.ReadLine().Split();
            for (int j = 0; j < 3; j++)
                m[i, j] = double.Parse(row[j]);
        }

        double det =
            m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) -
            m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0]) +
            m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);

        Console.WriteLine("Детерминанта: " + det);
    }
}
