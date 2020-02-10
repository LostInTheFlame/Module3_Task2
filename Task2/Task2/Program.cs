using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число N: ");
            string n = Console.ReadLine();

            if (int.TryParse(n, out int N))
            {
                if (N > 0)
                {
                    Console.WriteLine($"\nЧётные натуральные числа:");
                    for (int i = 2; i <= N * 2; i += 2)
                    {
                        Console.WriteLine($"{i}");
                    }
                }
                else
                {
                    Console.WriteLine("\nЧётных натуральных чисел нет.");
                }
            }
            else
            {
                Console.WriteLine("\nЗначение введено неверно.");
            }
            Console.ReadKey(true);
        }
    }
}