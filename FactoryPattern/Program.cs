using FactoryPattern.Factory;
using FactoryPattern.Products;

namespace FactoryPattern;

public class Program
{
    static void Main(string[] args)
    {
        ObjectFactory objectFactory = new ObjectFactory();

        var bat = objectFactory.Get(ObjectType.Bat) as Bat;
        var ball = objectFactory.Get(ObjectType.Ball) as Ball;

        Console.WriteLine(bat.GetInfo());
        Console.WriteLine(ball.GetInfo());

        Console.ReadLine();
    }
}
