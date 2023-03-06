using System;
using System.Linq;

namespace LINQFunctions
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 12, 7, 2, 15, 1, 18, 75, 155, 321, 400, 815, 980 };

            //Aggregate
            int total = numbers.Aggregate((a, b) => a + b);

            //Count

            var totalItemsInArray = numbers.Count();

            //Min
            var smallestItem = numbers.Min();

            //Max
            var BiggestItem = numbers.Max();

            //Sum
            var TotalofArray = numbers.Sum();

            Console.WriteLine("Agg Total"+ total);
            Console.WriteLine("Total Items"+totalItemsInArray);
            Console.WriteLine("Smallest " + smallestItem);
            Console.WriteLine("Biggest " + BiggestItem);
            Console.WriteLine("SumTotal " + TotalofArray);





            Console.ReadLine();
        }
    }
}
