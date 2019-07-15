namespace software_craftsmanship.Lib.Sorting_Algorithms
{
    // O(N^2) - WORST CASE
    // O(N) - BEST CASE
    public class BubbleSort: ISort
    {
        public int[] ReturnSortedList(int [] data)
        {
            int i, j;
            var N = data.Length;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        var tmp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = tmp;
                    }
                }
            }
            return data;
        }
    }
}
