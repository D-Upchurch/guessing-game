using System;

Console.WriteLine("Guess a number between 1-10!");

void SecretNumber()
{
    Console.Write("Your guess: ");
    string answer = Console.ReadLine();
    string correctAnswer = "5";
    if (answer == correctAnswer)
    {
        Console.WriteLine("You are correct!");
    }
    else if (answer != correctAnswer)
    {
        Console.WriteLine("That is incorrect, sorry!");
    }
}

SecretNumber();
