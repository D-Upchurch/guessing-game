using System;

Console.WriteLine("Guess a number between 1-10!");

void SecretNumber()
{
    int chances = 4;
    Console.WriteLine($"Your guess: ({chances} remaining)");
    int guessedNumber = int.Parse(Console.ReadLine());
    int secretNumber = 5;
    while (chances >= 1)
    {
        if (guessedNumber == secretNumber)
        {
            Console.WriteLine("You are correct! Good Game!");
            return;
        }
        else if (guessedNumber != secretNumber)
        {
            Console.WriteLine($"That is incorrect.");
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
                    Console.WriteLine($"That is incorrect.");
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

