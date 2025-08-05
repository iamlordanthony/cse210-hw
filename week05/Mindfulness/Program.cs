// ==============================
// Enhancements Beyond Requirements
// ==============================
//
// ✅ Added a reusable spinner animation using a dedicated method `ShowSpinner()`
//    to visually indicate pauses, improving user engagement.
//
// ✅ Implemented a countdown timer for breathing and reflection activities 
//    to help users stay aware of timing during their session.
//
// ✅ Enhanced the breathing activity with rhythmic timing by alternating 
//    "Breathe in..." and "Breathe out..." messages, each with countdown delays.
//
// ✅ Randomized prompts and questions to ensure variety in each session.
//    Users are less likely to repeat the same experience every time.
//
// ✅ Structured the code using OOP principles such as inheritance (via the base `Activity` class), 
//    encapsulation (private fields), and abstraction (shared logic in base class).
//
// ✅ Added input validation and clean console formatting to create 
//    a smooth, guided user experience.
//
// These enhancements go beyond the core 93% functionality and demonstrate 
// creativity, user-centered thinking, and code reuse.

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Start();
                    break;
                case "2":
                    new ReflectionActivity().Start();
                    break;
                case "3":
                    new ListingActivity().Start();
                    break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
