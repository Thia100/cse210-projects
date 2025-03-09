using System;
using System.Globalization;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 101);

        int number = -1;
        
        int i = 0;
        while (number != magic_number)
        {
            Console.Write("Input a number: ");
            number = int.Parse(Console.ReadLine());

            if (number > magic_number)
            {
                Console.WriteLine("lower");
            }
            else if (number < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else{
                Console.WriteLine($"You guessed right! You guessed {i} times");
                break;
            }
            i++;
        }

    }
}