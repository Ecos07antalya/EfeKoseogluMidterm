using System;

class Program
{
    static void Main(string[] args)
    {
        // Introduction and Name Input
        Console.WriteLine("Welcome to the adventure! What's your name?");
        string playerName = Console.ReadLine();
        Console.WriteLine($"\nHello, {playerName}! This is a journey of choices. Let's see where your path leads.\n");

        // Question 1
        Console.WriteLine("1. Would you rather live in:");
        Console.WriteLine("   a) A bustling city");
        Console.WriteLine("   b) A quiet countryside");
        Console.WriteLine("   c) By the ocean");
        Console.Write("Your choice: ");
        string answer1 = Console.ReadLine().ToLower();

        // Question 2
        if (answer1 == "a")
        {
            Console.WriteLine("\n2. In a city, what would you prioritize?");
            Console.WriteLine("   a) Career opportunities");
            Console.WriteLine("   b) Nightlife and social events");
            Console.WriteLine("   c) Convenience of services");
        }
        else if (answer1 == "b")
        {
            Console.WriteLine("\n2. What do you value most in the countryside?");
            Console.WriteLine("   a) Peace and quiet");
            Console.WriteLine("   b) Nature and wildlife");
            Console.WriteLine("   c) Small community vibes");
        }
        else if (answer1 == "c")
        {
            Console.WriteLine("\n2. Living by the ocean, what excites you most?");
            Console.WriteLine("   a) The sound of waves");
            Console.WriteLine("   b) Water sports and activities");
            Console.WriteLine("   c) Stunning sunrises and sunsets");
        }
        else
        {
            Console.WriteLine("\nInvalid choice! Restart the game.");
            return;
        }
        Console.Write("Your choice: ");
        string answer2 = Console.ReadLine().ToLower();

        // Question 3
        Console.WriteLine("\n3. If you had the chance, would you rather:");
        Console.WriteLine("   a) Travel through time to the past");
        Console.WriteLine("   b) Travel to the distant future");
        Console.WriteLine("   c) Stay in the present and create your own destiny");
        Console.Write("Your choice: ");
        string answer3 = Console.ReadLine().ToLower();

        // Question 4
        Console.WriteLine("\n4. What's your ideal way to spend a weekend?");
        Console.WriteLine("   a) Exploring nature");
        Console.WriteLine("   b) Hanging out with friends");
        Console.WriteLine("   c) Reading or learning something new");
        Console.Write("Your choice: ");
        string answer4 = Console.ReadLine().ToLower();

        // Question 5 (Dynamic based on answer3)
        if (answer3 == "a")
        {
            Console.WriteLine("\n5. If you could visit the past, which era intrigues you the most?");
            Console.WriteLine("   a) Ancient civilizations like Egypt or Rome");
            Console.WriteLine("   b) The Renaissance period");
            Console.WriteLine("   c) The 20th century");
        }
        else if (answer3 == "b")
        {
            Console.WriteLine("\n5. In the distant future, what would you explore?");
            Console.WriteLine("   a) Advanced technology");
            Console.WriteLine("   b) Colonized planets");
            Console.WriteLine("   c) The evolution of humanity");
        }
        else
        {
            Console.WriteLine("\n5. In the present, what's most important to you?");
            Console.WriteLine("   a) Building strong relationships");
            Console.WriteLine("   b) Achieving personal growth");
            Console.WriteLine("   c) Making a positive impact on others");
        }
        Console.Write("Your choice: ");
        string answer5 = Console.ReadLine().ToLower();

        // Question 6
        Console.WriteLine("\n6. What's your dream adventure?");
        Console.WriteLine("   a) A trek through uncharted wilderness");
        Console.WriteLine("   b) A luxurious world cruise");
        Console.WriteLine("   c) Building something meaningful, like a legacy");
        Console.Write("Your choice: ");
        string answer6 = Console.ReadLine().ToLower();

        // Results
        Console.WriteLine($"\nThanks for playing, {playerName}! Based on your answers, here’s a glimpse into who you are:");
        if (answer1 == "a" && answer3 == "a" && answer6 == "a")
        {
            Console.WriteLine("You're a curious soul, drawn to adventure and the stories of the past.");
        }
        else if (answer1 == "b" && answer2 == "b" && answer4 == "a")
        {
            Console.WriteLine("You have a deep connection with nature and a peaceful spirit that values the simpler things in life.");
        }
        else if (answer1 == "c" && answer2 == "b" && answer6 == "b")
        {
            Console.WriteLine("The ocean calls to you. You're a person who loves freedom and seeks joy in life’s experiences.");
        }
        else if (answer3 == "b" && answer5 == "a" && answer6 == "c")
        {
            Console.WriteLine("You’re a visionary, captivated by the future and driven to leave a legacy.");
        }
        else
        {
            Console.WriteLine("You’re a unique individual with diverse interests and a balanced approach to life.");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
