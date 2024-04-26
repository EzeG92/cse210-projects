using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percent? ");
        string percent = Console.ReadLine();
        float number = float.Parse(percent);
        float last_digit = number % 10;


        string letter;
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign;
        if (last_digit >= 7)
        {
            sign = "+ ";
        }
        else if (last_digit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = " ";
        }

        if (number >= 93 || number < 60)
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is an {letter}{sign}.");

        if (number >= 70)
        {
            Console.WriteLine("Congrats, you passed the course");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the course. Try again next time");
        }

    }
}