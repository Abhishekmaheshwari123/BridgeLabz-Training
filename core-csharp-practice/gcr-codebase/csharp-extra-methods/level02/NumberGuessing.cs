using System;

class NumberGuessing
{
    static Random rand = new Random();

    static int GenerateGuess(int low, int high)
    {
        return rand.Next(low, high + 1);
    }

    static string GetFeedback(int guess)
    {
        Console.Write("Is " + guess + " too (H)igh, (L)ow, or (C)orrect? ");
        return Console.ReadLine().Trim().ToUpper();
    }

    static void PlayGame()
    {
        int low = 1, high = 100;

        while (true)
        {
            int guess = GenerateGuess(low, high);
            string feedback = GetFeedback(guess);

            if (feedback == "C")
            {
                Console.WriteLine("Yay! I guessed your number!");
                break;
            }
            else if (feedback == "H")
            {
                high = guess - 1;
            }
            else if (feedback == "L")
            {
                low = guess + 1;
            }
            else
            {
                Console.WriteLine("Invalid input. Enter H, L, or C.");
            }
        }
    }

    public static void Main()
    {
        Console.WriteLine("Think of a number between 1 and 100.");
        PlayGame();
    }
}
