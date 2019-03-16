using System;

namespace HelloWorld
{ 
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Your name: ");
            string name = Console.ReadLine();

            Console.Write("How many hours sleep did you get last night?");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, " + name);

            if (hoursOfSleep > 8)
            {
                Console.WriteLine("You are well rested");
            }
            else
            {
                Console.WriteLine("You need more sleep");
            }

        }
    }
}
