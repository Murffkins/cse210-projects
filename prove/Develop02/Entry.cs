class Entry
{
    public Entry()
    {

    }

    public Entry(string title, string prompt, string answer, string author)
    {
        // a setter
        this.date = DateTime.Now.ToShortDateString();

        // stretch challenge addition
        this.title = title;
        this.prompt = prompt;
        this.answer = answer;

        // stretch challenge addition
        this.author = author;
    }

    public Entry(string date, string title, string prompt, string answer, string author)
    {
        // setters
        this.date = date;
        // stretch challenge addition
        this.title = title;
        this.prompt = prompt;
        this.answer = answer;
        // stretch challenge addition
        this.author = author;
    }

    // Telling C# to take care of the getter/setter methods
    public string date { get; set; }

    // stretch challenge addition
    public string title { get; set; }
    public string prompt { get; set; }

    public string answer { get; set; }

    // stretch challenge addition
    public string author { get; set; }

    public override string ToString(){
        // stretch challenge addition (title and author)
        return date + System.Environment.NewLine + "Title: " + title + System.Environment.NewLine + prompt + System.Environment.NewLine + answer + System.Environment.NewLine + "Author: " + author;
    }
}