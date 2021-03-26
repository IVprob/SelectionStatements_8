using System;

namespace SelectionStatements_8
{
    class Program
    {
        static void Main(string[] args)
        {
                var r = new Random();
                var favNumber = r.Next(1, 1000);

                Console.WriteLine("Guess a number between 1 and 1000.");
                var userInput = int.Parse(Console.ReadLine());
    
                if (favNumber > userInput)
                {
                    Console.WriteLine($"Your guess of {userInput} is too low. {favNumber} is the answer.");
                }
                else if (favNumber < userInput)
                {
                    Console.WriteLine($"Your guess of {userInput} is to high. {favNumber} is the answer.");
                }
                else
                {
                    Console.WriteLine($"You nailed it!");
                }
        }
    }
}
