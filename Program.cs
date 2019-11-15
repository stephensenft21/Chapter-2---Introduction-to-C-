using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Adam";
            int cohort = 34;

            // reassigning varaibles
            name = "Jisie";
            cohort = 35;
            //string concatenation

            string greeting = "Hello " + name + ". Welcome to cohort " + cohort;
            // string interpolation 
            string greeting2 = $"Hello {name}. Welcome to Cohort {cohort}";

            bool isTheBest = cohort == 35;
            if (isTheBest)
            {
                Console.WriteLine("Ah, the best around");
            }
            else
            {
                Console.WriteLine("You ");
            }

            Console.WriteLine(greeting2);

            int[] cohorts = new int[]
            {
                34,
                35,
                36,
                37
            };
            for (int i = 0; i < cohorts.Length; i++)
            {
                Console.WriteLine($"Cohort {cohorts[i]}");
            }
            foreach (int taco in cohorts)
            {
                Console.WriteLine($"{taco}");
            }

            while (cohort > 0)
            {
                cohort--;
                Console.WriteLine(cohort);
            }

        }
    }

}