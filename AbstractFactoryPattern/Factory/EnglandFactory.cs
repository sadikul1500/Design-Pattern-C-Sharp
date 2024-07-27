using AbstractPattern.CapitalCityProduct;
using AbstractPattern.LanguageProduct;
using AbstractPattern.Product;

namespace AbstractPattern.Factory;

public class EnglandFactory : IInternationalFactory
{
    public ICapitalCity CreateCapitalCity()
    {
        return new London();
    }

    public ILanguage CreateLanguage()
    {
        return new English();
    }
}
