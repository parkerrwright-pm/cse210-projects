using System;

class Program
{
    static void Main(string[] args)
    {       
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("Guess the magic number: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}