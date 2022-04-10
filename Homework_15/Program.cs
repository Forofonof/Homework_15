using System;

    internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int limitMinimum = 1;
        int limitMaximum = 27;
        int numberMininum = 100;
        int numberMaxinum = 999;
        int number;
        int count = 0;

        number = random.Next(limitMinimum, limitMaximum);

        for (int i = number; i <= numberMaxinum; i += number)
        {
            if (i > numberMininum)
            {
                count++;
                Console.Write($"{i}, ");
            }
        }
        Console.WriteLine($"\nКоличество натуральных чисел - {count}. \nЧисло N - {number}.");
    }
}