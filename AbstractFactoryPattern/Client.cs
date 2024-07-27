using AbstractPattern.CapitalCityProduct;
using AbstractPattern.Factory;
using AbstractPattern.Product;

namespace AbstractPattern;

public class Client
{
    private readonly ILanguage _language;
    private readonly ICapitalCity _capitalCity;

    public Client(IInternationalFactory factory)
    {
        _language = factory.CreateLanguage();
        _capitalCity = factory.CreateCapitalCity();
    }

    public void DisplayGreeting()
    {
        _language.Greet();
    }

    public void DisplayCapitalCityInfo()
    {
        Console.WriteLine($"Population: {_capitalCity.GetPopulation()} million");
        Console.WriteLine("Tourist Places: " + string.Join(", ", _capitalCity.GetTouristPlaces()));
    }
}
