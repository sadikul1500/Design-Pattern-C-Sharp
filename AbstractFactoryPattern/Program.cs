using AbstractPattern.Factory;

namespace AbstractPattern;

public class Program
{
    public static void Main(string[] args)
    {
        IInternationalFactory banglaFactory = InternationalFactoryProvider.GetFactory(Country.Bangladesh);
        var banglaClient = new Client(banglaFactory);
        banglaClient.DisplayGreeting();
        banglaClient.DisplayCapitalCityInfo();

        IInternationalFactory englandFactory = InternationalFactoryProvider.GetFactory(Country.England);
        var englandClient = new Client(englandFactory);
        englandClient.DisplayGreeting();
        englandClient.DisplayCapitalCityInfo();

        Console.ReadLine();
    }
}
