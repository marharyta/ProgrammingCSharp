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
            int[] num = new int[7];
            int number;
            int sum = 0;
            int quant = 0;
            for (int counter = 0; counter < num.Length; counter++)
            { 
                Console.Write("Write a number: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number < 0)
                {
                    Console.Write("Enter args positive number!");
                }
                else 
                {
                    num[counter] = number;
                    quant = counter;
                    sum = sum + counter;

                }
            }
            Array.Sort(num);
            Console.Write(num[sum/quant]);
            Console.ReadLine();
        }
    }
}
