using System;
using System.Threading.Channels;

/* Ask the user for their name and store it. /
   The name is used throughout the program /
   The user is called a coward if they do not agree to the COIN FLIP CHALLENGE /
   Only do the COIN FLIP CHALLENGE if the user agrees. /
   Loop the challenge 5 times /
   The program grabs a random number between 0 and 1 (You still get this point even if nothing is done with it.) /
   The user is asked for heads or tails and their value is stored. /
   A solution was found to compare the random number to the heads or tails input that works./
   Every correct answer adds one to the score./
   The score is displayed at the end of the challenge
 */
namespace CoinFlipD2
{
    class MainClass
    {
        
        public static void Main(string[] args)
        
        {
            int score = 0;
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Do you want to do the COIN FLIP CHALLENGE?");
            string choice = Console.ReadLine();
            if (choice == "No")
            {
                Console.WriteLine(name + ", you COWARD!");
            }

            if (choice == "Yes") 
               
                {
                    int i;
                    for (i = 1; i <= 5; i++)
                        
            {
                Console.WriteLine();
                Random ran = new Random();
                int ranNum = ran.Next(0, 2);
                Console.WriteLine("Guess Heads or Tails " + name);
                string guess = Console.ReadLine();
                
                if (ranNum == 0 && guess == "Heads") 
                {
                    Console.WriteLine("HEADS - you win!");
                   ++score;
                    Console.WriteLine("Your score is " + score);
                }
                else if (ranNum == 1 && guess == "Tails")
                {
                    Console.WriteLine("TAILS - you win!");
                    ++score;
                    Console.WriteLine("Your score is " + score);
                }
                else
                {
                    if (ranNum == 1 && guess == "Heads")
                    {
                        Console.WriteLine("Tails - you lose!");
                    }
                    else if (ranNum == 0 && guess == "Tails")
                    {

                        Console.WriteLine("Heads - you lose!");
                    }
                    
                }






            }


            }
        }
    }
}
            