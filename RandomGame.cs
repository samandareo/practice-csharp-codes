using System;

namespace MyNamespace
{

}
class Program
{
    public static void Main(string[] args)
    {
        //0

        Console.WriteLine("Welcome to our game");


        while (true)
        {
            Random rand_num = new Random();
            int randomNumber = rand_num.Next(1, 101);

            Console.WriteLine("Select level:" +
          "\n1=> Easy (15 attempts)" +
          "\n2=> Medium (10 attempts)" +
          "\n3=> Hard (5 attempts)" +
          "\n0=> Exit");
            int level = Convert.ToInt32(Console.ReadLine());

            int attempt = 0;


            if (level == 1)
                attempt = 15;
            else if (level == 2)
                attempt = 10;
            else if (level == 3)
                attempt = 5;
            else if (level == 0)
                return;
            else
            {
                Console.WriteLine("Please enter exist number!");
                continue;
            }

            bool isFound = false;


            while (attempt != 0)
            {
                //1
                Console.WriteLine($"Please input number between 1 and 100: (attempts: {attempt})");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                attempt--;
                //2
                if (randomNumber == userNumber)
                {
                    Console.WriteLine("YOU WIN");
                    isFound = true;
                    break;
                }

                //3
                else if (randomNumber > userNumber)
                    Console.WriteLine($"Generated number is greater than {userNumber}");
                //4
                else if (randomNumber < userNumber)
                    Console.WriteLine($"Generated number is less than {userNumber}");
                //5
                Console.WriteLine($"Try again (remaining attempts: {attempt})");
            }

            int re_attempt = attempt;
            int easy_points = 7 * re_attempt;
            int medium_point = 10 * re_attempt;
            int hard_point = 20 * re_attempt;

            if (level == 1)
            {
                Console.WriteLine($"\nYour points : {easy_points}");
            }
            else if (level == 2)
            {
                Console.WriteLine($"\nYour points : {medium_point}");
            }
            else if (level == 3)
            {
                Console.WriteLine($"\nYour points : {hard_point}");
            }

            if (isFound)
                Console.WriteLine("Congratulations");
            else
                Console.WriteLine($"Generated number is : {randomNumber} (((");

            Console.WriteLine("GAME OVER!\n\n\n");

        }

    }
}
