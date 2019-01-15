using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter an integer: ");
                int num = int.Parse(Console.ReadLine());

                PowerGenerator(num);

                Console.WriteLine("Continue? y/n ");
                string keepGoing = Console.ReadLine();
                if (keepGoing.ToLower().Equals("n"))
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

            }
        }

        private static void PowerGenerator(int num)
        {
            Console.WriteLine("Number\tSquared\t Cubed");
            Console.WriteLine("======\t=======\t=====");
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i + "\t" + (int)Math.Pow(i, 2) + "\t" + (int)Math.Pow(i, 3));
            }
        }
    }
}
