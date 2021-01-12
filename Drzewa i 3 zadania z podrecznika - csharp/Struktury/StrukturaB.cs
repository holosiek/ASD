using System.Collections.Generic;

namespace ASD.Struktury
{
    public class StrukturaB
    {
        public Dictionary<int, int> Indexes = new Dictionary<int, int>();
        public int[] Arr;
        public int N;
        private int Size { get; set; }

        private static bool IsInBounds(StrukturaB set, int val)
        {
            return val < set.Size && val >= 0;
        }
        
        public static bool Push(int i, StrukturaB set)
        {
            if (IsInBounds(set, i) && !set.Indexes.ContainsKey(i))
            {
                set.Indexes[i] = set.N;
                set.Arr[set.N] = i;
                set.N++;
                return true;
            }

            return false;
        }
        
        public static int Pop(StrukturaB set)
        {
            int firstIndex = set.Arr[0];
            if (set.N > 0)
            {
                set.Indexes.Remove(set.Arr[set.N - 1]);
                int val = set.Arr[set.N-1];
                set.N--;
                return val;
            }

            return -1;
        }
        
        public static bool Search(int i, StrukturaB set)
        {
            return set.Indexes.ContainsKey(i);
        }
        
        public static bool Delete(int i, StrukturaB set)
        {
            if (set.Indexes.ContainsKey(i))
            {
                int index = set.Indexes[i];
                set.Indexes.Remove(i);
                int tempVal = set.Arr[set.N-1];
                set.Arr[set.N-1] = set.Arr[index];
                set.Arr[index] = tempVal;
                set.N--;

                return true;
            }

            return false;
        }

        public StrukturaB(int n)
        {
            Size = n;
            Arr = new int[n];
            N = 0;
        }
    }
}