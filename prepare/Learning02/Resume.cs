public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // for each job (from the custom Job class) in the _jobs list
        foreach (Job job in _jobs)
        {
            // calls the Display() in the custom Job class
            job.Display();
        }
    }
}