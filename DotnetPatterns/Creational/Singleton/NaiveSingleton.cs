namespace DotnetPatterns.Creational.Singleton;

public class NaiveSingleton
{
    private NaiveSingleton() { }
    private static NaiveSingleton? _instance;

    public static NaiveSingleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new NaiveSingleton();
        }
        return _instance;
    }
}