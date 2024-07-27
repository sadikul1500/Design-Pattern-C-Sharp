using AbstractPattern.Factory;

namespace AbstractPattern;

public class InternationalFactoryProvider
{
    public static IInternationalFactory GetFactory(Country country)
    {
        switch (country)
        {
            case Country.Bangladesh:
                return new BanglaFactory();
            case Country.England:
                return new EnglandFactory();
            default:
                throw new ArgumentException("Invalid country");
        }
    }
}
