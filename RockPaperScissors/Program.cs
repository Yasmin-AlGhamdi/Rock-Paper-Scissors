using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose between rock(0), paper(1) or scissors(2): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();

            int machine=rand.Next(0, 2); // Or you can write it like this int machine=rand.Next(3);

            if (choice <= 2)
            {
                Console.WriteLine("Machine chose: " + machine);

                if (machine == choice)
                {
                    Console.WriteLine("Tie");
                }
                else if ((machine == 0 && choice == 2) || (machine == 1 && choice == 0) || (machine == 2 && choice == 1))
                {
                    Console.WriteLine("Machine wins");
                }
                else
                {
                    Console.WriteLine("User wins");
                }
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
