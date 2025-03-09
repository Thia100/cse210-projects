using System;

class Program
{
    static void Main(string[] args)
    {
        string letter_grade = "";

        Console.Write("What is your grade percentage? ");
        string grade_percentage = Console.ReadLine();
        int grade = int.Parse(grade_percentage);

        int remainder = grade % 10;
        if (remainder >= 7){
            letter_grade = "+";
        }
        else if (remainder <3 && remainder >0){
            letter_grade = "-";
        }
        
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "E";
        }
        else{
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}{letter_grade}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else{
            Console.WriteLine("Better luck next time");
        }
       
    }
       
}