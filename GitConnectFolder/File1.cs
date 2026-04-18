using System;

class File1
{
    static void Main(string[] args)
    {
        // 1. Find Prime Numbers from 1 to 100
        Console.WriteLine("=== Prime Numbers from 1 to 100 ===");
        for (int num = 2; num <= 100; num++)
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
                Console.Write(num + " ");
        }
        Console.WriteLine();

        // 2. Find Multiples of 8 from 1 to 80
        Console.WriteLine("\n=== Multiples of 8 from 1 to 80 ===");
        for (int num = 1; num <= 80; num++)
        {
            if (num % 8 == 0)
                Console.Write(num + " ");
        }
        Console.WriteLine();

        // 3. Find Multiples of 10 from 1 to 100
        Console.WriteLine("\n=== Multiples of 10 from 1 to 100 ===");
        for (int num = 1; num <= 100; num++)
        {
            if (num % 10 == 0)
                Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
