namespace ASD.Sortowania
{
    public class InsertionSort : SortBase
    {
        public override void Sort()
        {
            for(int i=1; i<size; i++)
            {
                int element = arr[i];
                int j = i-1;

                while(j>=0 && arr[j]>element)
                {
                    arr[j+1] = arr[j];
                    j--;
                }

                arr[j+1] = element;
            }
        }

        public InsertionSort(int[] arr, int size)
        {
            this.arr = arr;
            this.size = size;
        }
    }
}