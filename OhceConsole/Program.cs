using System;
using OhceConsole.Business;

namespace OhceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IOhceResult ohceResult = new OhceResult();

            Console.WriteLine("Welcome to Ohce Kata");
            Console.WriteLine("Write a word o q to quit");

            string input = Console.ReadLine();

            while (input != "q")
            {
                Console.WriteLine(ohceResult.GetOhceResponse(input));
                input = Console.ReadLine();
            }            
        }
    }
}
