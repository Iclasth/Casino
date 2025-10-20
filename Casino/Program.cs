using TwoGuysTrading;

Random random = new Random();
double odds = 0.75;
Guy player = new Guy("The Player", 100);

Console.WriteLine("Welcome to Paulista's Casino!");
Console.WriteLine("------------------------------");
Console.WriteLine("Do you wanna play?");

string? answer = Console.ReadLine();

if (answer?.ToLower() != "yes")
{
    Console.WriteLine("Okay, maybe next time!");
    return;

}

while (player.Cash >= 0)
{
    Console.Clear();
    Console.WriteLine("Welcome to the game! The odds is 0.75");
    Console.WriteLine($"{player.Name} have {player.Cash} bucks");
    Console.WriteLine("How much do you wanna bet?");
    string? betAnswer = Console.ReadLine();
    
    if (betAnswer == null)
    {
        Console.WriteLine("Invalid bet amount.");
        Console.WriteLine("How much do you wanna bet?");
        betAnswer = Console.ReadLine();
    }

    if (int.TryParse(betAnswer, out int betAmount))
    {
        int cashGiven = (int)player.GiveCash(betAmount);
        int pot = cashGiven * 2;

        if (cashGiven == 0)
        {
            Console.WriteLine("You don't have enough cash to make that bet.");
            return;

        }
        if (random.NextDouble() < odds)
        {
            Console.WriteLine("You win!");
            player.ReciveCash(pot);
        }
        else
        {
            Console.WriteLine("You lose!");
            player.GiveCash(betAmount);
        }

        Console.WriteLine("Do you wanna play again? (yes/no)");
        string? playAgainAnswer = Console.ReadLine();

        if(playAgainAnswer?.ToLower() != "yes")
        {
            Console.WriteLine("Thanks for playing! See you next time.");
            break;
        }
    }

}
