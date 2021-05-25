using System;

Console.WriteLine("Guess a number between 1-10!");

void SecretNumber()
{
    Console.Write("Your guess: ");
    int guessedNumber = int.Parse(Console.ReadLine());
    int chances = 4;
    int secretNumber = 5;
    while (chances > 0)
    {
        if (guessedNumber == secretNumber)
        {
            Console.WriteLine("You are correct! Good Game!");

        }
        else if (guessedNumber != secretNumber)
        {
            Console.WriteLine($"That is incorrect, sorry! {chances} chances remaining.");
            chances--;
            Console.Write("Next guess? ");
            guessedNumber = int.Parse(Console.ReadLine());
            while (chances > 0)
            {
                if (guessedNumber == secretNumber)
                {
                    Console.WriteLine("You are correct! Good Game!");
                    return;
                }
                else if (guessedNumber != secretNumber)
                {
                    Console.WriteLine($"That is incorrect, sorry! {chances} chances remaining.");
                    chances--;
                    Console.Write("Next guess? ");
                    int secondGuess = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{secondGuess}");
                }
            }
        }

        Console.WriteLine("Sorry, you lose. Insert a quarter to play again");



    }
}


SecretNumber();

