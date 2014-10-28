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
            string[] names = new string[200];
            double[] rates = new double[200];
            string name;
            double rate = 0;
            int quant = 0;

            for (int counter = 0; ; counter++)
            {
                Console.Write("Name: ");
                name = Console.ReadLine();
                if (name == "exit")
                {
                    quant = counter;
                    break;
                }
                else
                {
                    names[counter] = name;
                    
                }
                Console.Write("Rating: ");
                rate = Convert.ToDouble(Console.ReadLine());
                rates[counter] = rate;
            }
            for (int counter = 0; counter < quant ; counter++)
            {
                Console.WriteLine("name: " + names[counter] + ", rating:  " + rates[counter]);
            }
            Console.ReadLine();
        }
    }
}
