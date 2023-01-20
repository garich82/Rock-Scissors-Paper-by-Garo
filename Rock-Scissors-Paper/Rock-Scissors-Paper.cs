﻿Console.WriteLine("Welcome to my \"Rock-Scissors-Paper\" game!");
Console.WriteLine();
Console.WriteLine("In order to play you simply neeed to choose one of the three options!");
Console.WriteLine("Your choice is compared to computer's choice and the winner gets a point.");
Console.WriteLine("Remember, rock smashes scissors, scissors cuts paper and paper covers rock.");
Console.WriteLine("First one to reach 3 points is the winner!!!");
int playerScore = 0;
int computerScore = 0;
int maxScore = 0;
while (maxScore < 3)
{
    char playersChoice = ' ';
    while (true)
    {
        Console.WriteLine();
        Console.Write("Please choose: [r]ock, [s]cissors or [p]aper (just type the letter): ");
        bool validChoice = char.TryParse(Console.ReadLine(), out playersChoice);
        if (validChoice && playersChoice != 'p' && playersChoice != 'r' && playersChoice != 's')
        {
            Console.WriteLine();
            Console.WriteLine("Error! Only 'p', 'r' or 's' are allowed.");
        }
        else if (!validChoice)
        {
            Console.WriteLine();
            Console.WriteLine("Error! Just one letter is needed.");
        }
        else
            break;
    }
    var rand = new Random();
    int computersChoiceInt = rand.Next(3);
    char computersChoice = ' ';
    switch (computersChoiceInt)
    {
        case 0:
            computersChoice = 'r';
            Console.WriteLine();
            Console.WriteLine("Computer chose Rock!");
            break;
        case 1:
            computersChoice = 's';
            Console.WriteLine();
            Console.WriteLine("Computer chose Scissors!");
            break;
        case 2:
            computersChoice = 'p';
            Console.WriteLine();
            Console.WriteLine("Computer chose Paper!");
            break;

    }
    if (computersChoice == playersChoice)
        Console.WriteLine("No one wins. Try again!");
    else if (computersChoice == 'r' && playersChoice == 's' || computersChoice == 's' && playersChoice == 'p'
        || computersChoice == 'p' && playersChoice == 'r')
    {
        Console.WriteLine("Sorry! Computer wins!");
        computerScore += 1;
    }
    else
    {
        Console.WriteLine("Congratulations! You win!");
        playerScore += 1;
    }
    Console.Write("Current result is: ");
    if (computerScore > playerScore)
    {
        Console.WriteLine($"{computerScore}:{playerScore} for Computer!");
        maxScore = computerScore;
    }
    else if (computerScore < playerScore)
    {
        Console.WriteLine($"{playerScore}:{computerScore} for Player");
        maxScore = playerScore;
    }
    else
    {
        Console.WriteLine($"{playerScore}:{computerScore} tie");
    }
}
Console.WriteLine();
Console.Write("And the winner is: ");
if (computerScore == 3)
    Console.WriteLine("COMPUTER!");
else
    Console.WriteLine("PLAYER!");