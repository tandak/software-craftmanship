namespace software_craftsmanship.Lib.Sorting_Algorithms
{
    //BEST CASE: O(N LOG (N)) 
    //WORST CASE: O(N^2)
    //Uses recursion
    public class QuickSort : ISort
    {
        public int[] ReturnSortedList(int[] data)
        {
            return Sort(data, 0, data.Length - 1);
        }

        private int[] Sort(int[] data, int low, int high)
        {
            if (low < high)
            {
                var partitioningIndex = Partition(data, low, high);

                // Recursively sort elements before partition and after partition 
                Sort(data, low, partitioningIndex - 1);
                Sort(data, partitioningIndex + 1, high);
            }

            return data;
        }

        /* This function takes last element as pivot, 
            places the pivot element at its correct 
            position in sorted array, and places all 
            smaller (smaller than pivot) to left of 
            pivot and all greater elements to right 
            of pivot */
        private static int Partition(int[] data, int low, int high)
        {
            var pivot = data[high];

            // index of smaller element 
            var i = low - 1;
            for (var j = low; j < high; j++)
                // If current element is smaller  
                // than the pivot 
                if (data[j] < pivot)
                {
                    i++;

                    // swap data[i] and data[j] 
                    var temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                }

            // swap data[i+1] and data[high] (or pivot) 
            var temp1 = data[i + 1];
            data[i + 1] = data[high];
            data[high] = temp1;

            return i + 1;
        }
    }
}