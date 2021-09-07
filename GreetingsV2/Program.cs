using System;

namespace GreetingsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja eesnime
            //programm küsib kasutaja perekonnanime
            //programm küsib kasutajalt, kasutades neid andmeid

            Console.WriteLine("Mis su nimi on?");
            string UserName = Console.ReadLine();
            Console.WriteLine("Mis su perekonnanimi on?");
            string LastName = Console.ReadLine();
            Console.WriteLine($"Hello, {UserName} {LastName}");
            Console.ReadLine();
           

        }
    }
}
