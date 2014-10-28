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
            Console.Write("How many destinations would you like to have? ");
              int counter = Convert.ToInt32(Console.ReadLine());
          
            string[] destinations = new string[counter];
            int[] distances = new int[counter];
            double[] prices = new double[counter];

            string destination;
            int distance = 0;
            double price = 0;
            double priceMin = 0;

            for (int index = 0; index < counter; index++ )
            {
                Console.Write("Destination:  ");
                destination = Console.ReadLine();
                destinations[index] = destination;
                Console.Write("Distance:  ");
                distance = Convert.ToInt32(Console.ReadLine());
                distances[index] = distance;
                Console.Write("Price:  ");
                price = Convert.ToDouble(Console.ReadLine());
                prices[index] = price;

                if (prices[index] < priceMin)
                {
                    priceMin = prices[index];
                }
                
            }
           
            for (int index = 0; index < counter; index++)
            {
                Console.WriteLine("Destination: " + destinations[index] + ", " + "Distance: "+ distances[index] + ", " + "Price per km: " + prices[index]);
                
            }
            Console.WriteLine("Min price per km: " + priceMin);
            Console.ReadLine();
        }
    }
}
