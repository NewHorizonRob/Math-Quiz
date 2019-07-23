using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7Homework
{
    class MathQuiz
    {
        static Random rand = new Random();
        int score;
      public MathQuiz()
        {
            score = 0;
        }

        public void AskQuestion(Difficulty diff)
        {
            if (diff == Difficulty.Easy)
            {
               // Random rand = new Random();
                int num1 = rand.Next(1, 100);
                int num2 = rand.Next(1, 100);
                Console.WriteLine("What is {0} + {1}", num1, num2);
                int ans = Convert.ToInt32(Console.ReadLine());

                int correct = num1 + num2;

                if (ans == correct)
                {
                    score++;
                    ShowCorrectMessage();
                   
                }
                else
                {
                    ShowIncorrectMessage();
                }
            }

            if (diff == Difficulty.Medium)
            {
                //Random rand = new Random();
                int num1 = rand.Next(50, 5000);
                int num2 = rand.Next(50, 5000);
                Console.WriteLine("What is {0} + {1}", num1, num2);
                int ans = Convert.ToInt32(Console.ReadLine());

                int correct = num1 + num2;

                if (ans == correct)
                {
                    score++;
                    ShowCorrectMessage();
                }
                else
                {
                    ShowIncorrectMessage();
                }
            }
            if (diff == Difficulty.Hard)
            {
              //  Random rand = new Random();
                int num1 = rand.Next(500, 5000);
                int num2 = rand.Next(500, 5000);
                Console.WriteLine("What is {0} + {1}", num1, num2);
                int ans = Convert.ToInt32(Console.ReadLine());

                int correct = num1 + num2;

                if (ans == correct)
                {
                    score++;
                    ShowCorrectMessage();
                }
                else
                {
                    ShowIncorrectMessage();
                }
            }
        }
        
        public void ShowCorrectMessage()
        {
          //  Random rand = new Random();
            int num1 = rand.Next(1, 5);

            switch (num1)
            {
                case 1:
                    Console.WriteLine("Good");
                    break;
                case 2:
                    Console.WriteLine("Great");
                    break;
                case 3:
                    Console.WriteLine("Excellent");
                    break;
                case 4:
                    Console.WriteLine("Phenomenal");
                    break;
            }
        }
        public void ShowIncorrectMessage()
        {
          //  Random rand = new Random();
            int num1 = rand.Next(1, 5);

            switch(num1)
            {
                case 1:
                    Console.WriteLine("wrong");
                    break;
                case 2:
                    Console.WriteLine("incorrect");
                    break;
                case 3:
                    Console.WriteLine("sorry");
                    break;
                case 4:
                    Console.WriteLine("try another time");
                    break;
            }
        }

        public void ShowScore()
        {
            Console.WriteLine("Your score {0}", score);
        }
    }
}
