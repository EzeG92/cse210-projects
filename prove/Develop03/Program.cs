using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi", 3, 7);
        
        string text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        
        Scripture scripture = new Scripture(reference, text);

        Console.Clear();

        Console.WriteLine(reference.GetDisplayText());
        Console.WriteLine(scripture.GetDisplayText());

    while (true)
    {
        Console.Write("\nPress enter to continue or type 'quit' to finish: ");
        string choice = Console.ReadLine();

        if (choice.ToLower() == "quit")
        {
            return;
        }

        scripture.HideRandomWords(3);

        if (scripture.IsCompletelyHidden())
        {
            break;
        }

        Console.Clear();

        Console.WriteLine(reference.GetDisplayText());
        Console.WriteLine(scripture.GetDisplayText());

    }
        
    }
}