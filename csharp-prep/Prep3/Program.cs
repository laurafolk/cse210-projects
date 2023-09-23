using System;

class Program
{
    static void Main(string[] args)
    {
//        Console.Write("What is the magic number? ");  //Core requirement 1 & 2
//       string answer = Console.ReadLine();
//        int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();  //Core requirement 3
        int magicNumber = randomGenerator.Next(1, 101);  //Core requirement 3

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.WriteLine("Welcome to the Magic Number Game. ");  //Core requirement 3
            Console.Write("What is your guess? ");  //Core requirement 3
            guess = int.Parse(Console.ReadLine());  //Core requirement 3

//Core requirment 1        string guess = Console.ReadLine()
//Core requirment 1        int number = int.Parse(guess);

            if (magicNumber > guess)
            {
            Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
            Console.WriteLine("Lower");
            }
            else
            {
            Console.WriteLine("Congratulations you guessed it! ");
            }
        }
    }
}