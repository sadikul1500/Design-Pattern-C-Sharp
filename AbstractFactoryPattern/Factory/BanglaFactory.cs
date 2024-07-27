using AbstractPattern.CapitalCityProduct;
using AbstractPattern.LanguageProduct;
using AbstractPattern.Product;

namespace AbstractPattern.Factory;

public class BanglaFactory : IInternationalFactory
{
    public ICapitalCity CreateCapitalCity()
    {
        return new Dhaka();
    }

    public ILanguage CreateLanguage()
    {
        return new Bangla();
    }
}
