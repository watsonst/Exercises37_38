using System;

namespace Exercise_38
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] userArray = new int[5];
            string userAnswer = string.Empty;

            do
            {
                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine("Enter a number: ");
                    userArray[i] = Convert.ToInt32(Console.ReadLine());
                }

                int average = (userArray[0] + userArray[1] + userArray[2] + userArray[3] + userArray[4]) /5;

                string averageTotal = ($"({userArray[0]} + {userArray[1]} + {userArray[2]} + {userArray[3]} + {userArray[4]})/5 = {average}");

               
                Console.WriteLine($"{averageTotal}");

                Console.Write("Would you like to continue (y/n)? ");
                userAnswer = Console.ReadLine().ToLower();

                if (userAnswer == "n")
                {
                    Console.WriteLine("GoodBye");
                }

            } while (userAnswer == "y");

        }

    }
}
