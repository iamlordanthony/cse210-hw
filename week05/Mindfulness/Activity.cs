public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"--- {name} ---\n");
        Console.WriteLine(description);
        Console.Write("\nHow long (in seconds) would you like this session? ");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        Utils.ShowSpinner(3);
        PerformActivity();
        End();
    }

    protected abstract void PerformActivity();

    protected void End()
    {
        Console.WriteLine("\nWell done!");
        Utils.ShowSpinner(3);
        Console.WriteLine($"\nYou completed the {name} activity for {duration} seconds.");
        Utils.ShowSpinner(3);
    }
}
