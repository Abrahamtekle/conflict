using System;

class File2
{
    static void Main(string[] args)
    {
        // 1. Even Numbers from 1 to 100
        Console.WriteLine("=== Even Numbers from 1 to 100 ===");
        for (int num = 1; num <= 100; num++)
        {
            if (num % 2 == 0)
                Console.Write(num + " ");
        }
        Console.WriteLine();

        // 2. Odd Numbers from 1 to 100
        Console.WriteLine("\n=== Odd Numbers from 1 to 100 ===");
        for (int num = 1; num <= 100; num++)
        {
            if (num % 2 != 0)
                Console.Write(num + " ");
        }
        Console.WriteLine();

        // 3. All Numbers from 1 to 100
        Console.WriteLine("\n=== All Numbers from 1 to 100 ===");
        for (int num = 1; num <= 100; num++)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
