using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers_list = new List<int>();
       
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int sum = 0; 
        

        while (true)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number == 0) 
            {
                break;
            }

            numbers_list.Add(number); 

        }

        int maxnumber = numbers_list[0];
        foreach (int num in numbers_list)
        {
            sum += num;
            if (num > maxnumber){
                maxnumber = num;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum/numbers_list.Count}");
        Console.WriteLine($"The highestnumber is: {maxnumber}");
        numbers_list.Sort();
        Console.WriteLine("Sorted List: " + string.Join(", ", numbers_list));
        
    }
}
