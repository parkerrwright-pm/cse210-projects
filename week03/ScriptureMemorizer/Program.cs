namespace ScriptureMemorizer;

class Program
{
    static void Main(string[] args)
    {
        // Customization: choose a scripture at random from the Scriptures Library.
        ScripturesLibrary library = new ScripturesLibrary();
        Scripture scripture = library.GetRandomScripture();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to finish:");

            string? input = Console.ReadLine();

            if (input is null ||
                input.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}