using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7Homework
{
    class MathQuiz
    {
        static Random rand = new Random(); #initializes the random class for use
        int score; #creates an int named score
      
        public MathQuiz()
        {
            score = 0;
        }

        public void AskQuestion(Difficulty diff) #method for asking the easy math question 
        {
            if (diff == Difficulty.Easy) #if the user chooses the easy difficulty 
            {
               // Random rand = new Random();
                int num1 = rand.Next(1, 100); #randomly picks a number between 1 and 100
                int num2 = rand.Next(1, 100); #randomly picks a number between 1 and 100
                Console.WriteLine("What is {0} + {1}", num1, num2); #asks the user for the answer between the 2 random numbers
                int ans = Convert.ToInt32(Console.ReadLine()); #converts the ans variable

                int correct = num1 + num2; #the correct variable is the answer between the two random integers

                if (ans == correct) # if the user answer and correct match up then add to score and show the correct message
                {
                    score++;
                    ShowCorrectMessage();
                   
                }
                else
                {
                    ShowIncorrectMessage(); #else show the incorrect message 
                }
            }

            if (diff == Difficulty.Medium)#if the user chooses the medium difficulty 
            {
                //Random rand = new Random();
                int num1 = rand.Next(50, 5000);#randomly picks a number between 50 and 500
                int num2 = rand.Next(50, 5000);#randomly picks a number between 50 and 500
                Console.WriteLine("What is {0} + {1}", num1, num2);#asks the user for the answer between the 2 random numbers
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
            if (diff == Difficulty.Hard)#if the user chooses the hard difficulty 
            {
              //  Random rand = new Random();
                int num1 = rand.Next(500, 5000);#randomly picks a number between 500 and 5000                
                int num1 = rand.Next(500, 5000);#randomly picks a number between 500 and 5000
                Console.WriteLine("What is {0} + {1}", num1, num2);#asks the user for the answer between the 2 random numbers
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
        
        public void ShowCorrectMessage() #metod for showing different messages when user answer is correct
        {
          //  Random rand = new Random();
            int num1 = rand.Next(1, 5); #num1 variable uses the random number generator between 1 and 5 

            switch (num1) #switch allows different messages to be displayed based on the random number that is selected by the generator
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
        public void ShowIncorrectMessage() #same setup as the correct message but is used when the user answer is incorrect 
        {
          //  Random rand = new Random();
            int num1 = rand.Next(1, 5);

            switch(num1)#switch allows different messages to be displayed based on the random number that is selected by the generator
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

        public void ShowScore() #method for showing the score for the user
        {
            Console.WriteLine("Your score {0}", score); #writes out the score to the console 
        }
    }
}
