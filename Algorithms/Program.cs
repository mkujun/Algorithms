using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 12, 1, 88, 21, 42, 2 };

            //SelectionSort sort = new SelectionSort(array);            
            BubbleSort sort = new BubbleSort(array);

            //print out array before sorting
            sort.PrintArray(array);

            sort.Sort();
            sort.PrintArray(array);

            // Keep the console window open in debug mode.
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
