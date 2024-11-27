using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace krokodilleOppgave
{
    internal class Krokodille
    {
        public void Run()
        {
            Random rand = new Random();

            int score = 0;
            bool isPlaying = true;

            while (isPlaying)
            {
                int randomNr1 = rand.Next(0, 11); // inside loop so they always generate new numbers
                int randomNr2 = rand.Next(0, 11);

                Console.WriteLine($"{randomNr1} _ {randomNr2}");
                var userInput = Console.ReadLine();

                if (randomNr1 < randomNr2 && userInput == "<" || randomNr1 > randomNr2 && userInput == ">" || randomNr1 == randomNr2 && userInput == "=")
                {
                    score++;
                    Console.WriteLine($"Correct! You get a point! Your score is now: {score}");
                }
                else if(userInput == "<" || userInput == ">" || userInput == "=")
                {
                    score--;
                    Console.WriteLine($"Wrong answer.. You lose a point. Your score is now: {score}");
                }
                else // if the symbol written does not match <, >, or =
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Invalid answer. Game Over.");
                    isPlaying = false; // exits loop
                }

                Console.WriteLine();
            }
            
            Console.WriteLine($"Your final score is: {score}");
            Console.WriteLine("The game will now shut down.");

            Thread.Sleep(3000);
            Environment.Exit(0); 
        }
    }
}
