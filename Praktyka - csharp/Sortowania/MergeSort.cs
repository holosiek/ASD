namespace ASD.Sortowania
{
    public class MergeSort : SortBase
    {
        private void Merge(int left, int mid, int right)
        {
            int size1 = mid-left+1;
            var leftArr = new int[size1];

            for(int i=0; i<size1; i++)
            {
                leftArr[i] = arr[left+i];
            }
            
            int size2 = right-mid;
            var rightArr = new int[size2];

            for(int i=0; i<size2; i++)
            {
                rightArr[i] = arr[mid+1+i];
            }

            int x = 0;
            int y = 0;
            int k = left;
            
            while(x<size1 && y<size2){
                if(leftArr[x]<=rightArr[y])
                {
                    arr[k] = leftArr[x];
                    x++;
                }
                else
                {
                    arr[k] = rightArr[y];
                    y++;
                }
                k++;
            }
            
            while(x<size1)
            {
                arr[k] = leftArr[x];
                x++;
                k++;
            }

            while(y<size2)
            {
                arr[k] = rightArr[y];
                y++;
                k++;
            }
        }
        
        private void Sort(int left, int right)
        {
            if (left < right) {
                int mid = (left+right)/2;

                Sort(left, mid);
                Sort(mid+1, right);
                Merge(left, mid, right);
            }
        }

        public override void Sort()
        {
            Sort(0, size-1);
        }

        public MergeSort(int[] arr, int size)
        {
            this.arr = arr;
            this.size = size;
        }
    }
}