using System;
using System.Reflection.Metadata.Ecma335;

namespace Lab_2._2_Table_of_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = true;
            string entry;
            int number;
            while (done)
            { 
                Console.WriteLine($"Learn your squares and cubes!\n");
                Console.WriteLine($"Enter an integer:"); //user inputs integer here
                entry = Console.ReadLine();
                number = int.Parse(entry);       
            
                Console.WriteLine($"Number\t\tSquared\t\tCubed");
                Console.WriteLine($"=======\t\t=======\t\t=======");

                for (int i=0; i<number;)
                {
                    i++;
                    int square = i * i;
                    int cube = i * i * i;
                    Console.WriteLine(String.Format("{0,7}{1,16}{2,16}", i, i * i, i * i * i));
                }
            
                Console.WriteLine($"Continue? (y/n)");
                string cont = Console.ReadLine();
                if (cont == "n" || cont == "N")
                {
                    done = false;
                }
                else if (cont != "y")
                {
                    Console.WriteLine($"That's not a valid input.");
                    Console.WriteLine($"We're going to default to N");
                    done = false;
                }
            }

            Console.WriteLine($"Have a great day!");
        }
    }
}
