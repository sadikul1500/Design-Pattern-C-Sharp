using AbstractPattern.Product;

namespace AbstractPattern.LanguageProduct;

public class English : ILanguage
{
    public void Greet()
    {
        Console.WriteLine("Hello in English");
    }
}
