public class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "When have you felt the Spirit this month?",
        "Who are some of your heroes?"
    };

    public ListingActivity() : base("Listing", "This activity helps you reflect on the good in your life by listing things.")
    {
    }

    protected override void PerformActivity()
    {
        Random rand = new Random();
        Console.WriteLine($"\nPrompt: {prompts[rand.Next(prompts.Length)]}");
        Console.WriteLine("You have a few seconds to think before listing begins...");
        Utils.ShowCountdown(5);

        List<string> items = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
    }
}
