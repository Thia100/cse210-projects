using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber =  PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName (){
        Console.Write("Please enter your name:");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number:");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }
    static int SquareNumber(int favNumber){
        int square = favNumber * favNumber;
        return square;

    }
    static void DisplayResult(string name, int square){
        Console.WriteLine($"{name}, the square of your number is {square}");
        
    }
}