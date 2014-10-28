using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[5];
           

            for (int counter = 0; counter < num.Length; counter++)
            {
                Console.Write("Number: ");
                num[counter] = Convert.ToDouble(Console.ReadLine());
            }
            for (int counter = num.Length - 1; counter >= 0; counter--)
            {
                Console.Write(num[counter] + "; ");
            }
            Console.ReadLine();
        }
    }
}
