using AbstractPattern.Product;

namespace AbstractPattern.LanguageProduct;

public class Bangla: ILanguage
{
    public void Greet()
    {
        Console.WriteLine("Hello in Bangla");
    }
}
