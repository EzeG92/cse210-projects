using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Welcome to the Goal Manager!");

        Console.Write("What is your name?: ");
        string nameUser = Console.ReadLine();
        Console.WriteLine();

        GoalManager start = new GoalManager(nameUser);
        start.Start();
    }
}