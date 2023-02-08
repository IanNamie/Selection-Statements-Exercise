using System.Reflection.Metadata.Ecma335;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I want to play a game! guess my favorite number!");
            int favNumber = 82;
            int userGuess = int.Parse(Console.ReadLine()); 

            if (userGuess == favNumber) 
            {
                Console.WriteLine("That is correct great job!");
            }
            else if (userGuess < favNumber)
            {
                Console.WriteLine("Aww close but thats to low!");
            }
            else 
            { 
                Console.WriteLine("Aww good guess but thats to high!");
            }


        }
    }
}
