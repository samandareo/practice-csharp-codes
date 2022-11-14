using System;
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Topishmoqlarni topishga tayyormisiz? Unda boshladik!");
        Console.WriteLine("Qozonda emas qaynaydi, Qishin yozin tinmaydi?");
        string userSentence = Console.ReadLine();

        if(userSentence == "Buloq" || userSentence == "buloq" || userSentence == "BULOQ")
        {
            Console.WriteLine("Ajoyib, topishmoqning javobini topdingiz\n\n Keyingi topishmog'imiz!");
        }
        else
        {
            Console.WriteLine("Afsuski topa olmadingiz, javobi buloq\n\n Keyingi topishmog'imiz" );
        }

        // Keyingisi
        Console.WriteLine("Ko'zga ko'rinmas, qo'lga tutilmas?");
        string userSentence2 = Console.ReadLine();

        if (userSentence2 == "Havo" || userSentence2 == "havo" || userSentence2 == "HAVO")
        {
            Console.WriteLine("Ajoyib, topishmoqning javobini topdingiz!");
        }
        else
        {
            Console.WriteLine("Afsuski topa olmadingiz, javobi havo");
        }

    }
    }
