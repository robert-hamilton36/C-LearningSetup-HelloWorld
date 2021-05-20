using System;
using IntroLibrary;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel p = new PersonModel
            {
                FirstName = "Obi Wan",
                LastName = "Kenobi"
            };

            System.Console.WriteLine($"Jedi Master { p.FirstName } { p.LastName }");

            Console.WriteLine("Hello There!");
            System.Console.WriteLine("General Kenobi");
            System.Console.WriteLine("You are a bold one");
        }
    }
}
