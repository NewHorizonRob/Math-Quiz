using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter choices (E)asy, (M)edium, or (H)ard"); #writes message out to the console

            MathQuiz n = new MathQuiz(); #initializes an instance from the MathQuiz class
            string choice = Console.ReadLine(); #used to see what choice the user will select 

            if (choice == "E") #if the choice is E or Easy 
            {
                int counter = 1;
                while (counter <= 10) #while loop asks 10 questions 
                {
                    n.AskQuestion(Difficulty.Easy); #calls the AskQuestion Method and uses the difficulty enum class as a parameter
                    counter++;
                }
                n.ShowScore(); #shows the user score after the 10 questions are asked 
            }
            if (choice == "M") #if the choice is E or Easy 
            {
                int counter = 1;
                while (counter <= 10) #while loop asks 10 questions 
                {
                    n.AskQuestion(Difficulty.Medium);#calls the AskQuestion Method and uses the difficulty enum class as a parameter
                    counter++;
                }
                n.ShowScore(); #shows the user score after the 10 questions are asked 
            }
            if (choice == "H")
            {
                int counter = 1;
                while (counter <= 10)#while loop asks 10 questions 
                {
                    n.AskQuestion(Difficulty.Hard); #calls the AskQuestion Method and uses the difficulty enum class as a parameter
                    counter++;
                }
                n.ShowScore(); #shows the user score after the 10 questions are asked 
            }
            Console.WriteLine("PAK");
            Console.ReadKey();
        }
    }
}
