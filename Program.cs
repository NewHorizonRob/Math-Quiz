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
            Console.WriteLine("Enter choices (E)asy, (M)edium, or (H)ard");

            MathQuiz n = new MathQuiz();
            string choice = Console.ReadLine();

            if (choice == "E")
            {
                int counter = 1;
                while (counter <= 10)
                {
                    n.AskQuestion(Difficulty.Easy);
                    counter++;
                }
                n.ShowScore();
            }
            if (choice == "M")
            {
                int counter = 1;
                while (counter <= 10)
                {
                    n.AskQuestion(Difficulty.Medium);
                    counter++;
                }
                n.ShowScore();
            }
            if (choice == "H")
            {
                int counter = 1;
                while (counter <= 10)
                {
                    n.AskQuestion(Difficulty.Hard);
                    counter++;
                }
                n.ShowScore();
            }
            Console.WriteLine("PAK");
            Console.ReadKey();
        }
    }
}
