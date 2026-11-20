//Customization: I customized the journal program to save and load entries using JSON instead of separator-based text files.
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    Entry entry = new Entry(DateTime.Now.ToShortDateString(), prompt, response);
                    journal.AddEntry(entry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Filename: ");
                    string saveFile = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(saveFile))
                    {
                        journal.SaveToFile(saveFile);
                    }
                    else
                    {
                        Console.WriteLine("Filename cannot be empty.");
                    }
                    break;
                case "4":
                    Console.Write("Filename: ");
                    string loadFile = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(loadFile))
                    {
                        journal.LoadFromFile(loadFile);
                    }
                    else
                    {
                        Console.WriteLine("Filename cannot be empty.");
                    }
                    break;
                case "5":
                    running = false;
                    break;
                case null:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Please choose an option from 1 to 5.");
                    break;
            }
        }
    }
}
