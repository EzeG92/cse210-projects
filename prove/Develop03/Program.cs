using System;

//Exceeding Requirements: I created a dictionary where five different scriptures are saved and then randomly choose each of them each time the program is run
class Program
{
    static void Main(string[] args)
    {
         // Create a dictionary to map references to their corresponding texts
        Dictionary<Reference, string> scriptures = new Dictionary<Reference, string>()
        {
            { new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them." },
            { new Reference("Ether", 12, 27), "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them." },
            { new Reference("Mosiah", 2, 17), "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God." },
            { new Reference ("James", 1, 5, 6), "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.\nBut let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed."},
            { new Reference ("Doctrine and Covenants", 4, 2), "Therefore, O ye that embark in the service of God, see that ye serve him with all your heart, might, mind and strength, that ye may stand blameless before God at the last day."}
        };

        // Use a random number generator to select a reference
        Random rand = new Random();
        int index = rand.Next(scriptures.Count);
        Reference reference = scriptures.Keys.ElementAt(index);

        // Create a new Scripture object with the selected reference
        string text = scriptures[reference];
        Scripture scripture = new Scripture(reference, text);

        Console.Clear();

        Console.WriteLine(reference.GetDisplayText());
        Console.WriteLine(scripture.GetDisplayText());

        // Loop until the user quits or all words are hidden
        while (true)
        {
            Console.Write("\nPress enter to continue or type 'quit' to finish: ");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "quit")
            {
                return;
            }

            scripture.HideRandomWords(3); // Hide 3 random words in the scripture text

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