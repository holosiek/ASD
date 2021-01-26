using System;

namespace ASD.Sortowania
{
    public abstract class SortBase
    {
        protected int[] arr;
        protected int size;
        
        public abstract void Sort();

        public void Print()
        {
            foreach (int i in arr)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.Write("\n");
        }
    }
}