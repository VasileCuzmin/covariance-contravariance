using Cache;
using Microsoft.Extensions.Caching.Memory;

//var cache = new MemoryCache(new MemoryCacheOptions());

int counter = 0;

//Parallel.ForEach(Enumerable.Range(1, 10), i =>
//{
//    var item = cache.GetOrCreate("test-key", cacheEntry =>
//    {
//        cacheEntry.SlidingExpiration = TimeSpan.FromSeconds(10);
//        return Interlocked.Increment(ref counter);
//    });

//    Console.Write($"{item} ");
//});


//var cache = new SimpleMemoryCache<int>();

//var item = cache.GetOrCreate("test-key", () => 12);

//Console.Write($"{item} ");



//await Task.Delay(4000);

//var item1 = cache.GetOrCreate("test-key", () => 12);

//Console.Write($"{item1} ");

//Parallel.ForEach(Enumerable.Range(1, 3), i =>
//{
//    var item = cache.GetOrCreate("test-key", () => Interlocked.Increment(ref counter));

//    Console.Write($"{item} ");
//});
HashSet<string> names = new HashSet<string> {
    "Vasile"
};

names.Add("Vasile");


foreach (var name in names)
{
    Console.WriteLine(name);
}

if(names.Contains("Vasile",null))
Console.ReadKey();