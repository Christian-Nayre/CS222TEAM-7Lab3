using System;
using NotesDiary;

class Program
{
    static void Main()
    {
        Diary diary = new Diary();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== DIGITAL DIARY ===");
            Console.WriteLine("1. Write a New Entry");
            Console.WriteLine("2. View All Entries");
            Console.WriteLine("3. Search Entry by Date");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string? choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case "1":
                    Console.Write("Write your diary entry (press Enter to submit): ");
                    string? entry = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(entry))
                    {
                        diary.WriteEntry(entry);
                    }
                    else
                    {
                        Console.WriteLine("Empty entry not saved.");
                    }
                    break;

                case "2":
                    diary.ViewAllEntries();
                    break;

                case "3":
                    Console.Write("Enter date to search (YYYY-MM-DD): ");
                    string? date = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(date))
                    {
                        diary.SearchByDate(date);
                    }
                    else
                    {
                        Console.WriteLine("Invalid date input.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Goodbye! See you again :)");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress any key to return to menu...");
                Console.ReadKey();
            }
        }
    }
}
