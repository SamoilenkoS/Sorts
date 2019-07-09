using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortAlgorithms;

namespace Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new int[5] { 5, 2, 1, 4, 3 };
            SortAlgorithms<int>.MergeSort(test);
            foreach (var item in test)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }
    }
}
