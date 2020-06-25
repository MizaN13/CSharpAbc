using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "mizan";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuess = false;
            int guessLimitRemain = guessLimit;

            while (guess != secretWord && !outOfGuess)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("You have " + Convert.ToString(guessLimitRemain) + " try left.");
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                    guessLimitRemain--;
                }
                else
                {
                    outOfGuess = true;
                }
                
            }
            if (outOfGuess)
            {
                Console.WriteLine("Out of Guess, You Lose :(");
            }
            else
            {
                Console.WriteLine("You Win!!!!!");
            }           

            Console.ReadLine();
        }
    }
}
