using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
                       Console.WriteLine("Hello , Please enter amount of names!");
                       var numberOfNames = Console.ReadLine();
                       if(numberOfNames.GetType() == typeof(int)) {
                           Console.WriteLine("You can enter names! GoodLuck");
                            int numberOfNames2 = Convert.ToInt32(numberOfNames);
                            string[] names = new string[numberOfNames2];
                            for (int f = 0; f < numberOfNames2; f++)
                            {
                            names[f] = Console.ReadLine();
                            }
                            Console.WriteLine("\n");
                            var i = 0;
                            while (i < names.Length)
                            {
                                Console.WriteLine(i + 1 + ":" + names[i]);
                                i++;
                            }
                       }
                       else 
                       {
                           Console.WriteLine("Please, enter number");
                           int amountOfNames = Convert.ToInt32(Console.ReadLine());
                           Console.WriteLine("You can enter names! GoodLuck");
                           string[] names2 = new string[amountOfNames];
                            
                           for (int f = 0; f < amountOfNames; f++)
                           {
                           names2[f] = Console.ReadLine();
                           }

                           Console.WriteLine("\n");

                           var d = 0;
                           while (d < names2.Length)
                           {
                               Console.WriteLine(d + 1 + ":" + names2[d]);
                               d++;
                           }
                       }

                  
        }
    }
}
