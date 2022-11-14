using System;
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int rand_num = rd.Next(0,101);
            Console.WriteLine("Please, you enter number (1 => 101)");
            string get_number = Console.ReadLine();

            int gt_number = Convert.ToInt32(get_number);

            if(rand_num == gt_number)
            {
                Console.WriteLine("You win");
            }else if (rand_num > gt_number)
            {
                Console.WriteLine("Generated number is greater than " + gt_number);
                Console.WriteLine("Game Over");
            }
            else
            {
                Console.WriteLine("Generated number is less than " + gt_number);
                Console.WriteLine("Game Over");
            }
    ;
        }
    }
