using System;

namespace Felsökning
{
    class Program
    {
        static void Main(string[] args)
        {
            // CASE 1
            int number = 2;

            if (number > 3)
            {
                Console.WriteLine("Talet är större än tre");// Glömt ett semicolon
            }
            else if (number < 3) // Mellanslag mellan else och if.
            {
                Console.WriteLine("Talet är mindre än tre");
            }

            // CASE 2
            for (int i = 1; i <= 100; i++) // la till ett lika med tecken för att räkna till och med 100.
            {
                Console.WriteLine(i);
            }

            // CASE 3
            for (int i = 1; i <= 5; i++) //La till ++ efter i.
            {
                for (int j = 1; j <= i; j++) // La till ++ efter j.
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            //CASE 4
            int i = 1;
            while (i <= 5)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j); // för att skriva ut värdet på variablen j.
                }

                Console.WriteLine();
                i++;
            }

            //CASE 5
            int i = 1;

            switch (i)
            {
                case 1:
                    Console.WriteLine("One"); // la till denna för visa.
                    break; // la till ett break för att särskilja case 1 och case 2
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }



            //CASE 6
            int i = 10;

            if (i == 5) // la till ett lika med tecken så att det blir ett jämförelse tecken och inte ett tilldelnings tecken.
            {
                Console.WriteLine("i är 5");
            }






        }

    }
}
