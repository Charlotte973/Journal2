namespace Journal2.Properties;

class Journal
{
    private Database database;

    public Journal()
    {
        database = new Database();
    }

    private DateTime readDateTime()
    {
        Console.WriteLine("Enter datetime:");
        DateTime dateTime;
        while (! DateTime.TryParse(Console.ReadLine(), out dateTime))
            Console.WriteLine("Error. Try again:");
        return dateTime;
    }

    public void PrintEntries(DateTime day)
    {
        List<Entry> entries = database.getEntries(day, false);
        foreach (var entry in entries)
            Console.WriteLine(entry);
    }

    public void AddEntry()
    {
        DateTime dateTime = readDateTime();
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();
        database.addEntry(dateTime, text);
    }

    public void SearchEntry()
    {
        DateTime dateTime = readDateTime();
        List<Entry> entries = database.getEntries(dateTime, false);
        if (entries.Count > 0)
        {
            Console.WriteLine("Entry found");
            foreach (var entry in entries)
                Console.WriteLine(entry);
        }
        else
        {
            Console.WriteLine("No entry found");
        }
        
    }

    public void DeleteEntries()
    {
       Console.WriteLine("Entry with same date and time will be deleted");
        DateTime dateTime = readDateTime();
        database.removeEntry(dateTime);
    }

    public void HomeScreen()
    {
        Console.Clear();
        Console.WriteLine("MY JOURNAL");
        Console.WriteLine("Today is: {0}", DateTime.Now);
        Console.WriteLine();
        Console.WriteLine("My today:\n---------");
        PrintEntries(DateTime.Now);
        Console.WriteLine();
    }
    
}