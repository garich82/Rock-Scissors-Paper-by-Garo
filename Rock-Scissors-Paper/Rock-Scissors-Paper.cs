Console.WriteLine("Welcome to my \"Rock-Scissors-Paper\" game!");
Console.WriteLine();
Console.WriteLine("In order to play you simply neeed to choose one of the three options!");
Console.WriteLine("Your choice is compared to computer's choice and the winner gets a point.");
Console.WriteLine("Remember, rock smashes scissors, scissors cuts paper and paper covers rock.");
Console.WriteLine("First one to reach 3 points is the winner!!!");
int playerScore = 0;
int computerScore = 0;
// The main loop is executed until someone reaches the target score.
while (!(playerScore == 3 || computerScore == 3))
{
    // This loop is being executed until player enters valid choice: p, r or s.
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
    // Randomizing computer's choice. Random int: 0 for [R]ock, 1 for [S]cissors and 2 for [P]aper.
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
    // Deciding who wins the current round.
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
    // Printing the current result.
    Console.Write("Current result is: ");
    if (computerScore > playerScore)
        Console.WriteLine($"{computerScore}:{playerScore} for Computer!");
    else if (computerScore < playerScore)
        Console.WriteLine($"{playerScore}:{computerScore} for Player");
    else
        Console.WriteLine($"{playerScore}:{computerScore} tie")
}
// Printing the final result.
Console.WriteLine();
Console.Write("And the winner is: ");
if (computerScore == 3)
    Console.WriteLine("COMPUTER!");
else
    Console.WriteLine("PLAYER!");