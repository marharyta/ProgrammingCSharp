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
            int number = 0;
           

            for(int counter = 0; counter < num.Length; counter++)
            {
                Console.Write("Something: ");
                number = Convert.ToInt32(Console.ReadLine());
                if ((number >= 1) && (number <= 39))
                {
                        num[counter] = number;
                        
                }
                else 
                {
                    Console.WriteLine("1-39, please!!!: ");
                }
                
            }
            Array.Sort(num);
            
            for (int counter = 0; counter < num.Length; counter++)
            {
                Console.Write(num[counter] + ", ");
            }
            Console.ReadLine();

        }
    }
}
