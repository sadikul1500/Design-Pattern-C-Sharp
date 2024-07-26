using FactoryPattern.Products;

namespace FactoryPattern.Factory;

public class ObjectFactory
{
    private ObjectType _objectType;

    public IObject Get(ObjectType type)
    {
        _objectType = type;

        return GetObject();
    }

    private IObject GetObject()
    {
        IObject obj = null;

        switch (_objectType)
        {
            case ObjectType.Bat:
                obj = new Bat(1, "GM", 1.32, "A");
                break;
            case ObjectType.Ball:
                obj = new Ball(1, "Duke", 0.50, "White");
                break;
            default:
                break;
        }

        return obj;
    }
}

public enum ObjectType
{
    Bat,
    Ball
}
