namespace Journal2.Properties;

public class Entry
{
    public DateTime Occurs { get; set; }
    public string Text { get; set; }

    public Entry (DateTime occurs, string text)
    {
        Occurs = occurs;
        Text = text;
    }

    public override string ToString()
    {
        return Occurs + " " + Text;
    }
    
}