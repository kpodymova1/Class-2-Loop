using System;

namespace PodymovaClassWeek3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years of experience do you have in professional programming?");
            var years = Console.ReadLine();
            int years1 = int.Parse(years);
            var count = 0;

            for (int i = 1; i <= years1; i++)
            {
                Console.WriteLine("You have " + i + " years of experience");
                count++;
            }
        }
    }
}
