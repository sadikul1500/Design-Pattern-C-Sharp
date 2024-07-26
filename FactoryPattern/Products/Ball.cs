using FactoryPattern.Factory;

namespace FactoryPattern.Products;

public class Ball: IObject
{
    public int Id { get; set; }
    public string Type { get; set; }
    public double Weight { get; set; }
    public string Color { get; set; }

    public Ball(int Id, string Type, double Weight, string Color)
    {
        this.Id = Id;
        this.Type = Type;
        this.Weight = Weight;
        this.Color = Color;
    }

    public virtual String GetInfo()
    {
        return String.Format("Ball type is {0}. Weight is {1} kg. Color is {2}.", Type, Weight, Color);
    }
}
