using System.Collections.Generic;

namespace software_craftsmanship.Lib.Benchmarking
{
    public class MaxPurchasableV1
    {
        private static readonly Dictionary<int, int> BrandIdsDictionary = new Dictionary<int, int>
        {
            {15816, 6},
            {3441, 6},
            {15818, 6},
            {15815, 6},
            {15817, 6},
            {160, 6},
            {15919, 6},
            {13735, 6}
        };

        public int? Compute(int brandId)
        {
            return BrandIdsDictionary.TryGetValue(brandId, out var value)
                ? (int?) 6
                : null;
        }
    }
}