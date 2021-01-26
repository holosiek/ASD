namespace ASD.Struktury
{
    public class StrukturaA
    {
        private class Value
        {
            public readonly int Data;

            public Value(int data)
            {
                Data = data;
            }
        }
        private Value[] Arr { get; set; }
        private int[] Indexes { get; set; }
        private int Size { get; }
        private int N { get; set; }

        private static bool IsInBounds(StrukturaA set, int val)
        {
            return val < set.Size && val >= 0;
        }

        public static int Select(StrukturaA set)
        {
            if (set.N > 0)
            {
                set.N--;
                int ind = set.Indexes[set.N];
                int result = set.Arr[ind].Data;
                set.Arr[ind] = null;
                return result;
            }
            
            return -1;
        }
        
        public static bool Search(int val, StrukturaA set)
        {
            return IsInBounds(set, val-1) && !(set.Arr[val-1] is null);
        }
        
        public static bool Insert(int val, StrukturaA set)
        {
            if (IsInBounds(set, val-1) && set.Arr[val-1] is null)
            {
                set.Arr[val-1] = new Value(val);
                set.Indexes[set.N] = val-1;
                set.N++;
                return true;
            }

            return false;
        }
        
        public StrukturaA(int n)
        {
            Size = n;
            Arr = new Value[Size];
            Indexes = new int[Size];
            N = 0;
        }
    }
}