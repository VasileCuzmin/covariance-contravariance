using Microsoft.Extensions.Caching.Memory;
using System.Collections.Concurrent;

namespace Cache;

public class Cache<T>
{
    private readonly Dictionary<object, T> _internalCache = new();

    public T GetOrCreate(object key, Func<T> createItem)
    {
        if (!_internalCache.ContainsKey(key))
        {
            _internalCache[key] = createItem();
        }

        return _internalCache[key];
    }
}

public class SimpleMemoryCache<T>
{
    private MemoryCache _cache = new MemoryCache(new MemoryCacheOptions());

    public T GetOrCreate(object key, Func<T> createItem)
    {
        if (!_cache.TryGetValue(key, out T cacheEntry))
        {
            cacheEntry = createItem();

            var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetSize(1)
                .SetPriority(CacheItemPriority.High)
                .SetSlidingExpiration(TimeSpan.FromSeconds(2))
                .SetAbsoluteExpiration(TimeSpan.FromSeconds(10));

            _cache.Set(key, cacheEntry, cacheEntryOptions);
        }

        return cacheEntry;
    }
}

public class WaitToFinishMemoryCache<T>
{
    private MemoryCache _cache = new MemoryCache(new MemoryCacheOptions());
    private readonly ConcurrentDictionary<object, SemaphoreSlim> _locks = new ConcurrentDictionary<object, SemaphoreSlim>();

    public async Task<T> GetOrCreate(object key, Func<Task<T>> createItem)
    {
        if (_cache.TryGetValue(key, out T cacheEntry))
        {
            return cacheEntry;
        }

        var myLock = _locks.GetOrAdd(key, k => new SemaphoreSlim(1, 1));
        await myLock.WaitAsync();

        try
        {
            //if (!_cache.TryGetValue(key, out cacheEntry))
            //{
            cacheEntry = await createItem();
            _cache.Set(key, cacheEntry);
            //}
        }
        finally
        {
            myLock.Release();
        }

        return cacheEntry;
    }
}