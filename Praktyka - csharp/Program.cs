using System;

namespace ASD
{
    internal static partial class Program
    {
        public static void Main(string[] args)
        {
            TestyInsertionSort(); // Teoria 1
            TestyMergeSort();     // Teoria 2
            TestyHeapSort();      // Teoria 3
            //TestyDrzew();       // Teoria 4
            //TestyStruktur();    // Teoria 5
            
            string holdConsole = Console.ReadLine();
        }
    }
}
