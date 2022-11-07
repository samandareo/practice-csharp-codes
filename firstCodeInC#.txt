using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
            Console.WriteLine("Hello, welcome to our service company. Please, Fill out the following form!");
    Console.WriteLine("What's your name?");
    string firstName = Console.ReadLine();
    Console.WriteLine("What's your surname?");
    string lastName = Console.ReadLine();
    Console.WriteLine("How old are you?");
    string age = Console.ReadLine();
    Console.WriteLine("What's your phone number?");
    string phoneNum = Console.ReadLine();
    Console.WriteLine("Your email:");
    string email = Console.ReadLine();
    Console.WriteLine("\nFirst name : " + firstName + "\nLast name : " + lastName + "\nAge : " + age + "\nPhone number : " + phoneNum + "\nEmail : " + email);
    Console.WriteLine("\nIf the information is correct, submit the Yes!");
    string submit = Console.ReadLine();
    Console.WriteLine("Thank you! We will be in touch soon!");
    }
}
