
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace software_craftsmanship.Lib.Features
{
    /*
     * Understanding Async Enumerable
     * ------------------------------
     * WHY?
     * When you want to retrieve data and be processing it as it is retrieved,
     * but not in a way that blocks CPU while you wait.
     * Basic Example:
     * IEnumerable<Foo> result = await bar.ExecuteAsync();
       
       foreach (var item in result) 
       {
       // Do work here
       ^^ 
       (1.) Looking at the above if ExecuteAsync is enumerated faster than the data 
       is arriving it will block waiting for more items to arrive. 
       This will block the executing thread.
       (2.) ExecuteAsync may wait until it has all of the data before returning. 
       This delays the point where DoWork may begin processing data.
       ---------------------------------
       IAsyncEnumerable<T> return a Task as the stream is iterated.
       This allows methods such as ExecuteAsync to return early and then wait for more data as it is iterated, 
       without blocking the thread.
     */
    public class AsyncEnumerable
    {
        /*public async IAsyncEnumerable<Foo> GetFooAsync()
        {
            for (var i = 0; i < 20; i++)
            {
                var item = await GetFooById(i);

                yield return item;
            }
        }

        private async Task<Foo> GetFooById(int id, CancellationToken cancellationToken = default)
        { //Mostly using this method so I have an async http call
         var httpClient = new HttpClient();
         var result = await httpClient.GetAsync("http://google.co.uk", cancellationToken);
         return JsonConvert.DeserializeObject<Foo>(result.Content.ToString());
        }

        public async IAsyncEnumerable<Foo> GetFooAsync([EnumeratorCancellation] CancellationToken cancellationToken)
        {
            for (var i = 0; i < 20; i++)
            {
                var item = await GetFooById(i, cancellationToken);

                yield return item;
            }
        }*/
    }

    public class Foo
    {
        public int Id;
        public string Thing;
    }
}
