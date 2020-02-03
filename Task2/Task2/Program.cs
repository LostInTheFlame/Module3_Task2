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
                if (N >= 0)
                {
                    Console.WriteLine($"\nЧётные натуральные числа от 0 до {N}:");
                    for (int i = 1; i <= N; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine($"{i}");
                        }
                    }
                }
                else Console.WriteLine("Натуральное число не может быть отрицательным.");
            }
            else Console.WriteLine("Значение введено неверно.");
            Console.ReadKey(true);
        }
    }
}
