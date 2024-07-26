namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            var s = Singleton.GetInstance;
            s.PrintDetails("Hello from Sadi");

            var r = Singleton.GetInstance;
            r.PrintDetails("Hello from Riyad");

            //var nested = new Singleton.NestedSingleton();

            Console.ReadLine();
        }
    }
}
