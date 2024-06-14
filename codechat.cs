using System;

class Program
{
    static int health = 100;
    static int score = 0;

    static void Main()
    {
        Console.WriteLine("Welcome to the Adventure Game!");
        Console.WriteLine("You are in a dark forest.");

        while (health > 0)
        {
            DisplayOptions();

            int choice;
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                ProcessChoice(choice);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    static void DisplayOptions()
    {
        Console.WriteLine("\nOptions:");
        Console.WriteLine("1. Go deeper into the forest.");
        Console.WriteLine("2. Rest by the campfire.");
        Console.WriteLine("3. Quit the game.");
    }

    static void ProcessChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                GoDeeper();
                break;
            case 2:
                Rest();
                break;
            case 3:
                QuitGame();
                return;
            default:
                Console.WriteLine("Invalid choice. Try again.");
                break;
        }

        health -= 10;
        if (health <= 0)
        {
            Console.WriteLine($"Game over. Your score: {score}");
        }
    }

    static void GoDeeper()
    {
        Console.WriteLine("You go farther into the forest and discover a treasure chest!");
        score += 10;
    }

    static void Rest()
    {
        Console.WriteLine("You rest by the campfire and regain 20 health.");
        health += 20;
    }

    static void QuitGame()
    {
        Console.WriteLine($"Thanks for playing! Your score: {score}");
        Environment.Exit(0);
    }
}