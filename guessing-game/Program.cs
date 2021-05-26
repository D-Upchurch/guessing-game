using System;

Console.WriteLine("Guess a number between 1-100!");

void SecretNumber()
{
    int chances = 4;
    Console.WriteLine($"Your guess: ({chances} remaining)");
    int guessedNumber = int.Parse(Console.ReadLine());
    Random rnd = new Random();
    int secretNumber = rnd.Next(1, 101);
    Console.WriteLine(secretNumber);
    while (chances >= 1)
    {
        if (guessedNumber == secretNumber)
        {
            Console.WriteLine("You are correct! Good Game!");
            return;
        }
        else if (guessedNumber != secretNumber)
        {
            if (guessedNumber > secretNumber)
            {
                Console.WriteLine("That is incorrect, your guess was too high.");
            }
            else if (guessedNumber < secretNumber)
            {
                Console.WriteLine("That is incorrect, your guess was too low.");
            }
            chances--;
            Console.WriteLine($"Guess again - ({chances} remaining)");
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
                    if (guessedNumber > secretNumber)
                    {
                        Console.WriteLine("That is incorrect, your guess was too high.");
                    }
                    else if (guessedNumber < secretNumber)
                    {
                        Console.WriteLine("That is incorrect, your guess was too low.");
                    }
                    chances--;
                    if (chances >= 1)
                    {
                        Console.WriteLine($"Guess again - ({chances} remaining)");
                        guessedNumber = int.Parse(Console.ReadLine());
                    }
                    else if (chances < 1)
                    {
                        Console.WriteLine("Sorry, you lose. Insert a quarter to play again");
                        return;
                    }
                }
            }

        }





    }
}


SecretNumber();

