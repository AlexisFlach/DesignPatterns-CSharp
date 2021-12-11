using System.Diagnostics;

namespace SingleResponsibility
{
    public class Journal
    {
        private readonly List<string> _entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string text)
        {
            _entries.Add($"{++count}: {text}");
            return count;
        }
        public void RemoveEntry(int index)
        {
            _entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _entries);
        }
    }

    public class Persistence
    {
        public void SaveToFile(Journal j, string fileName, bool overwrite = false)
        {
            if (overwrite || !File.Exists(fileName))
            {
                File.WriteAllText(fileName, j.ToString());
            }
        }
    }

    public class JournalSimulator
    {
        public static void Run()
        {
            var journal = new Journal();

            journal.AddEntry("Trying to learn the SRP");
            journal.AddEntry("Getting there...");
            journal.AddEntry("Got it!");
        
            Console.WriteLine(journal);

            var p = new Persistence();
            var filename = @"\journal.txt";
            p.SaveToFile(journal, filename);
            Process.Start(filename);
        }
    }
}