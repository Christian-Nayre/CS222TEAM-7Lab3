using System;
using System.IO;

namespace NotesDiary
{
    public class Diary
    {
        private string filePath = "diary.txt";

        public void WriteEntry(string text)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            using (StreamWriter writer = new StreamWriter(filePath, append: true))
            {
                writer.WriteLine($"{timestamp} | {text}");
            }

            Console.WriteLine("Entry successfully written.");
        }

        public void ViewAllEntries()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("No diary entries found.");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length == 0)
            {
                Console.WriteLine("Diary is empty.");
            }
            else
            {
                Console.WriteLine("---- All Entries ----");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
        }

        public void SearchByDate(string date)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("No diary entries found.");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            bool found = false;

            Console.WriteLine($"---- Entries on {date} ----");
            foreach (string line in lines)
            {
                if (line.StartsWith(date))
                {
                    Console.WriteLine(line);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No entries found for that date.");
            }
        }
    }
}
