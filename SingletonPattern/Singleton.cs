namespace SingletonPattern;
public sealed class Singleton
{
    private static int InstanceCounter = 0;
    public static Singleton Instance = null;
    public static Singleton GetInstance
    {
       get
       {
            if(Instance == null)
            {
                Instance = new Singleton();
            }
            return Instance;
       } 
    }

    private Singleton()
    {
        InstanceCounter++;
        Console.WriteLine("Counter Value " + InstanceCounter);
    }

    public void PrintDetails(string message)
    { 
        Console.WriteLine(message); 
    }

    //public class NestedSingleton : Singleton
    //{

    //}
}
