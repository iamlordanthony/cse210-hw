public class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself?",
        "How did you feel after it was complete?",
        "What could you apply from this to other situations?"
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    protected override void PerformActivity()
    {
        Random rand = new Random();
        Console.WriteLine($"\nPrompt: {prompts[rand.Next(prompts.Length)]}");
        Console.WriteLine("Reflect on the following questions...");

        DateTime end = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < end)
        {
            string q = questions[rand.Next(questions.Length)];
            Console.WriteLine($"\n> {q}");
            Utils.ShowSpinner(5);
        }
    }
}
