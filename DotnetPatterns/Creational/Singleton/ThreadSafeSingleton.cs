namespace DotnetPatterns.Creational.Singleton;

public class ThreadSafeSingleton
{
    private ThreadSafeSingleton() { }
    
    // Lazy<T> initializes an object only when it's needed also supports thread safety during creation
    // but for better code readability I'd prefer to use lock since it's used in many languages
    private static ThreadSafeSingleton _instance;
    private static readonly object _lock = new();

    public static ThreadSafeSingleton GetInstance()
    {
        // This condition is needed to prevent unnecessary lockings if singleton instance is already created
        // it also will work without it but a bit slower
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new ThreadSafeSingleton();
                }
            }
        }
        return _instance;
    }
}