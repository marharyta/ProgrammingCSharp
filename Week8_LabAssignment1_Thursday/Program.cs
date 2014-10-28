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
            int[] numbers = new int[5];
            int number = 0;
            int min = 0;
            int max = 0;
            int quant = 0;
            int sum = 0;
            for (int counter = 0; counter < numbers.Length; counter++)
            {
                Console.Write("Number: ");
                numbers[counter] = Convert.ToInt32(Console.ReadLine());
                number = numbers[counter];
                sum = sum + number;
                quant = counter + 1;
                min = max;

                if (numbers[counter] > max)
                {
                    max = numbers[counter];
                }

                
                else if (numbers[counter] < min)
                {
                    
                    min = numbers[counter];
                }
                
            }
            for (int counter = numbers.Length - 1; counter >= 0; counter--)
            {
                Console.Write(numbers[counter] + ", ");
               
            }
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Numbers in total: " + quant);
            Console.WriteLine("Max " + max);
            Console.WriteLine("Min: " + min);
            Console.ReadLine();
        }
    }
}
