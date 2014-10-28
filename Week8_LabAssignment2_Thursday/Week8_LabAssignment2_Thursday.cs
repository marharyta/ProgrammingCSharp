using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            int[] ages = new int[5];

            for(int counter = 0; counter < 5; counter++)
            {
                Console.Write("Name: ");
                names[counter] = Console.ReadLine();
                Console.Write("Age: ");
                ages[counter] = Convert.ToInt32(Console.ReadLine());


            }
            for (int counter = 0; counter <= 5; counter++)
            {
                Console.WriteLine(names[counter] + ": " + ages[counter] + ";");

            }
            Console.ReadLine();
        }
    }
}
