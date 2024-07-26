using FactoryPattern.Factory;

namespace FactoryPattern.Products;

public class Bat: IObject
{
    public int Id { get; set; }
    public string Model { get; set; }
    public double Weight { get; set; }
    public string Grade { get; set; }

    public Bat(int Id, string Model, double Weight, string Grade)
    {
        this.Id = Id;
        this.Model = Model;
        this.Weight = Weight;
        this.Grade = Grade;
    }

    public virtual String GetInfo()
    {
        return String.Format("Bat model is {0}. Weight is {1} kg. Grade is {2}.", Model, Weight, Grade);
    }
}
