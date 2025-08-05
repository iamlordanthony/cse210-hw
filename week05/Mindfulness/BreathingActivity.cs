
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through breathing in and out slowly.")
    {
    }

    protected override void PerformActivity()
    {
        DateTime end = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < end)
        {
            Console.Write("Breathe in...");
            Utils.ShowCountdown(4);
            Console.Write("Now breathe out...");
            Utils.ShowCountdown(6);
        }
    }
}
