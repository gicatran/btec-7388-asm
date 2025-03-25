using ASM.Lib.Constants;
using System.Collections.Concurrent;

namespace ASM.Lib {
    internal static class CacheManager {
        private static readonly ConcurrentDictionary<CacheGroup, ConcurrentDictionary<string, object>> _cacheGroups
            = new ConcurrentDictionary<CacheGroup, ConcurrentDictionary<string, object>>();

        public static void Set<T>(CacheGroup group, string key, T value) {
            var cache = _cacheGroups.GetOrAdd(group, _ => new ConcurrentDictionary<string, object>());
            cache[key] = value;
        }

        public static T Get<T>(CacheGroup group, string key) {
            if (_cacheGroups.TryGetValue(group, out var cache) && cache.TryGetValue(key, out var value)) {
                return value is T typedValue ? typedValue : default;
            }
            return default;
        }

        public static bool Exists(CacheGroup group, string key) {
            return _cacheGroups.TryGetValue(group, out var cache) && cache.ContainsKey(key);
        }

        public static T GetOrSet<T>(CacheGroup group, string key, System.Func<T> factory) {
            var cache = _cacheGroups.GetOrAdd(group, _ => new ConcurrentDictionary<string, object>());
            return (T)cache.GetOrAdd(key, _ => factory());
        }

        public static void Remove(CacheGroup group, string key) {
            if (_cacheGroups.TryGetValue(group, out var cache)) {
                cache.TryRemove(key, out _);
            }
        }

        public static void ClearGroup(CacheGroup group) {
            _cacheGroups.TryRemove(group, out _);
        }

        public static void ClearAll() {
            _cacheGroups.Clear();
        }
    }
}
