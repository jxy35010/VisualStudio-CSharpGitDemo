using System;

namespace _111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many years experience do you have in professional programming?");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                Console.WriteLine("you have "+i+" years of experience");

        }
    }
}
