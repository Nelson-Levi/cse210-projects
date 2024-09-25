using System;
using System.Formats.Asn1;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        // declare answer outside of the loop so it is accessible later
        string answer;
        do 
        {
            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(1,101);

            Console.WriteLine("Try to guess the magic number. ");
            int guess = 0;
            int count = 0;
            
            while (guess != magic)
            {
                string guessInput = Console.ReadLine();
                guess = int.Parse(guessInput);

                if (guess > magic)
                {
                    Console.WriteLine("Lower");
                }

                else if (guess < magic)
                {
                    Console.WriteLine("Higher");
                }

                // We can put this out here, because it'll activate every iteration of the while loop
                count ++;
            }
            Console.WriteLine($"You guessed it! The magic number was {magic}! ");
            Console.WriteLine($"You guessed {count} time(s). ");


            Console.WriteLine("Do you want to continue? ");
            answer = Console.ReadLine();
        } while (answer == "yes");
    }
}