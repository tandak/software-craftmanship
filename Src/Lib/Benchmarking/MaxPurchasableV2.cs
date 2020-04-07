using System.Collections.Generic;

namespace software_craftsmanship.Lib
{
    public class MaxPurchasableV2
    {
        private static readonly HashSet<int> BrandIdsHashSet = new HashSet<int>
            {15816, 3441, 15818, 15815, 15817, 160, 15919, 13735, 15970};

        public int? Compute(int brandId)
        {
            if (BrandIdsHashSet.Contains(brandId)) return 6;
            return null;
        }
    }
}