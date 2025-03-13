namespace Journal2.Properties;

class Database
{
    private List<Entry> entries;

    public Database()
    {
        entries = new List<Entry>();
    }

    public void addEntry(DateTime occurs, string text)
    {
        entries.Add(new Entry(occurs, text));
    }

    public List<Entry> getEntries(DateTime date, bool byTime)
    {
        List<Entry> found = new List<Entry>();
        foreach (var entry in entries)
        {
            if ((byTime) && (entry.Occurs >= date))
                found.Add(entry);
        }
        return found;
    }

    public void removeEntry(DateTime date)
    {
        List<Entry> found = getEntries(date, true);
        foreach (var entry in found)
            entries.Remove(entry);
    }
    
    
//this I got from ChatGPT after asking what is wrong with my code...
    public void saveEntries()
    {
        using (StreamWriter sw = new StreamWriter("entries.txt"))
        {
            foreach (var entry in entries)
            {
                sw.WriteLine($"{entry.Occurs},{entry.Text}");
            }
        }
    }
    
    
    public void loadEntries()
    {
        if (File.Exists("entries.txt"))
        {
            using (StreamReader sr = new StreamReader("entries.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    DateTime date = DateTime.Parse(parts[0]);
                    string text = parts[1];
                    entries.Add(new Entry(date, text));
                }
            }
        }
    }


}   