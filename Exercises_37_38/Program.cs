using System;

namespace Exercises_37_38
{ //Exercise 37
    class Program
    {
        static void Main(string[] args)
        {
            string userAnswer = string.Empty;
            do
            {
                Console.WriteLine($"{ArraySum(new int[5])}");

                Console.Write("Would you like to continue (y/n)? ");
                userAnswer = Console.ReadLine().ToLower();

                if (userAnswer == "n")
                {
                    Console.WriteLine("Goodbye!");
                }

            } while (userAnswer == "y");


        }


        public static string ArraySum(int[] userArray)
        {
            int i;
            userArray = new int[5];
            string userAnswer = string.Empty;


                for (i = 0; i < 5; i++)
                {
                    Console.Write("Enter a number: ");
                    userArray[i] = Convert.ToInt32(Console.ReadLine());
                }

                int sum = userArray[0] + userArray[1] + userArray[2] + userArray[3] + userArray[4];

                string sumTotal = ($"{userArray[0]} + {userArray[1]} + {userArray[2]} + {userArray[3]} + {userArray[4]} = {sum}");

                return $"{sumTotal}";

        }
    }
}
