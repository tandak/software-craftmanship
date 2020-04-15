namespace software_craftsmanship.Lib.Sorting_Algorithms
{
    // BEST CASE - O(N^2)
    // WORST CASE - O(N^2)
    public class SelectionSort : ISort
    {
        public int[] ReturnSortedList(int[] data)
        {
            int i;
            var N = data.Length;

            for (i = 0; i < N - 1; i++)
            {
                var k = IntArrayMin(data, i);
                if (i != k)
                {
                    var tmp = data[i];
                    data[i] = data[i + 1];
                    data[i + 1] = tmp;
                }
            }

            return data;
        }

        public static int IntArrayMin(int[] data, int start)
        {
            var minPos = start;
            for (var pos = start + 1; pos < data.Length; pos++)
                if (data[pos] < data[minPos])
                    minPos = pos;
            return minPos;
        }
    }
}