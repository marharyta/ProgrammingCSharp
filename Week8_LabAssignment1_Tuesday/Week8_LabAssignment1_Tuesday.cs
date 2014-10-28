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
            int[] numbers = new int[6];
            
            for (int counter = 0; counter < numbers.Length; counter++ )
            {
                Console.Write("Give a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 != 0)
                {
                    Console.Write("Error! Write an even number!");
                }
                else 
                {
                    numbers[counter] = num;
                }
            }
            for (int counter = 0; counter < numbers.Length; counter++)
            {
                Console.Write(numbers[counter] + ", ");
            }
            Console.ReadLine();
        }
    }
}
