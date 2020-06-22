using System;

namespace sampleProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey! What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What's your age?");
            string strAge = Console.ReadLine();
            int age = Int32.Parse(strAge);

            Console.WriteLine("What's your favorite color?");
            string color = Console.ReadLine();

            ConsoleColor bgColor = (ConsoleColor) Enum.Parse(typeof(ConsoleColor), color);
            Console.BackgroundColor = bgColor;
            Console.Clear();

            Console.WriteLine("Hi " + name + "!");

            if (age > 20)
            {
                Console.WriteLine("Have a beer!");
            }
            else
            {
                Console.WriteLine("Sorry, rootbeers only.");
            }

            

        }
    }
}

