namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for the user's name
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            // Ask if the user wants to do the COIN FLIP CHALLENGE
            Console.Write("Do you want to do the COIN FLIP CHALLENGE? (yes/no): ");
            string response = Console.ReadLine().Trim().ToLower();

            if (response != "yes")
            {
                Console.WriteLine($"{name}, you are a coward!");
                return;
            }

            // Initialize the score
            int score = 0;
            int rounds = 5;

            // Loop for the number of rounds
            Random random = new Random();
            for (int i = 0; i < rounds; i++)
            {
                int flip = random.Next(2); // 0 for heads, 1 for tails

                // Ask the user to guess heads or tails
                Console.Write("Heads or Tails? ");
                string guess = Console.ReadLine().Trim().ToLower();

                // Compare the guess with the flip
                if ((flip == 0 && guess == "heads") || (flip == 1 && guess == "tails"))
                {
                    score++;
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }

            // Output the total correct guesses
            Console.WriteLine($"{name}, your total correct guesses: {score}");
        }
    }
}