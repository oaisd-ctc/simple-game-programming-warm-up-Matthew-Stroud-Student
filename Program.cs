public class Program
{
    public static void Main(string[] args)
    {
        Start();
        Rounds();
    }

    public static void Start()
    {
        Console.Clear();
        Console.WriteLine("Dice Game");
        Console.WriteLine("");
        Console.WriteLine("In this game you and a computer Rival will play 10 rounds where you will each roll a 6-sided dice, and the player with the highest dice value will win the round. The player who wins the most rounds wins the game. Good luck!");
        Console.WriteLine("");
        Console.Write("Press any key to start...");
        Console.ReadKey();
        Console.WriteLine();
        Console.WriteLine();
    }

    public static int DiceRoll()
    {
        Random rnd = new Random();
        int diceRoll = rnd.Next(1, 7);
        return diceRoll;
    }

    public static void Rounds()
    {
        int round = 1;
        int playerScore = 0;
        int rivalScore = 0;
        while (true)
        {
            Console.WriteLine($"Round {round}");
            int rivalRoll = DiceRoll();
            Console.WriteLine($"Rival rolled a {rivalRoll}");
            Console.Write("Press any key to roll the dice...");
            Console.ReadKey();
            Console.WriteLine();
            int playerRoll = DiceRoll();
            Console.WriteLine($"You rolled a {playerRoll}");
            if (playerRoll > rivalRoll)
            {
                Console.WriteLine("You won this round.");
                playerScore++;
            }
            else if (playerRoll < rivalRoll)
            {
                Console.WriteLine("The Rival won this round.");
                rivalScore++;
            }
            else
            {
                Console.WriteLine("This round is a draw!");
            }
            Console.WriteLine($"The score is now - You : {playerScore}. Rival : {rivalScore}.");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
            round++;
            if (round > 10) //Add " || 11 - round < playerScore - rivalScore || 11 - round < rivalScore - playerScore" to end the game early when one of the players is guaranteed to win
            {
                Console.WriteLine();
                Console.WriteLine("Game over.");
                Console.WriteLine($"The score is now - You : {playerScore}. Rival : {rivalScore}.");
                if (playerScore > rivalScore)
                {
                    Console.WriteLine("You won!");
                }
                else if (playerScore < rivalScore)
                {
                    Console.WriteLine("You lost!");
                }
                else
                {
                    Console.WriteLine("This game is a draw.");
                }
                Console.Write("Press any key to exit...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Dice Game was closed.");
                break;
            }
            else
            {
                Console.WriteLine();
            }
        }

    }
}