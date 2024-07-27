using AbstractPattern.CapitalCityProduct;
using AbstractPattern.Product;

namespace AbstractPattern.Factory;

public interface IInternationalFactory
{
    ILanguage CreateLanguage();
    ICapitalCity CreateCapitalCity();
}
