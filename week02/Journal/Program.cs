using System;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Hello World! This is the Journal Project.");
            Console.WriteLine("1. Add entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save to file");
            Console.WriteLine("4. Load from file");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.Write("Enter your entry: ");
                    string entryText = Console.ReadLine();
                    Entry entry = new Entry(DateTime.Now.ToString(), prompt, entryText);
                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.Write("Enter file name: ");
                    string file = Console.ReadLine();
                    journal.SaveToFile(file);
                    break;
                case 4:
                    Console.Write("Enter file name: ");
                    file = Console.ReadLine();
                    journal.LoadFromFile(file);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }
}