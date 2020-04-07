using System.Collections;
using System.Collections.Generic;

namespace software_craftsmanship.Lib.Features
{
    /*
     * Understanding Async Enumerable
     * ------------------------------
     * WHY?
     * When you want to retrieve data and be processing it as it is retrieved,
     * but not in a way that blocks CPU while you wait.
     */
    public class AsyncEnumerable
    {
        //Basic
        public void GetInts()
        {
            IEnumerable src = new List<int>(){ 1, 3, 4, 7};
            foreach (int item in src) Use(item);
        }

        private void Use(int item)
        {
            throw new System.NotImplementedException();
        }
    }
}
