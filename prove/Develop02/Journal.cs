using System.Text;

class Journal
{
    public Journal()
    {
       this.entries = new List<Entry>();
    }
    public List<Entry> entries { get; set; }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        foreach (Entry entry in this.entries)
                    {
                        result.AppendLine(entry.ToString());
                    }
                    return result.ToString();
    }
}