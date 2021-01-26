namespace ASD.Sortowania
{
    public class HeapSort : SortBase
    {
        private void Swap(int ind1, int ind2)
        {
            int temp = arr[ind1];
            arr[ind1] = arr[ind2];
            arr[ind2] = temp;
        }
        
        private void Heapify(int siz, int i)
        {
            int largest = i;
            int left = i*2+1;
 
            if (left < siz && arr[left] > arr[largest])
            {
                largest = left;
            }
            
            int right = i*2+2;

            if(right < siz && arr[right] > arr[largest])
            {
                largest = right;
            }
 
            if(largest != i)
            {
                Swap(i, largest);
                Heapify(siz, largest);
            }
        }
        
        public override void Sort()
        {
            for(int i=size/2-1; i>=0; i--)
            {
                Heapify(size, i);
            }
 
            for(int i=size-1; i>0; i--)
            {
                Swap(0, i);
                Heapify(i, 0);
            }
        }

        public HeapSort(int[] arr, int size)
        {
            this.arr = arr;
            this.size = size;
        }
    }
}