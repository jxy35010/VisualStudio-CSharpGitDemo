using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years experience do you have in professional programming?");

            int input = int.Parse(Console.ReadLine());

            if (input == 0) 
            {
                Console.WriteLine("you need more practice");
            }

            if (input == 1)
            {
                Console.WriteLine("looks like you have a little experience");
            }
            if (input == 2) {
                Console.WriteLine("wow! you've been doing this for a little while");
            }
            else {
                Console.WriteLine("You are an expert");
            }

        }
    }
}
