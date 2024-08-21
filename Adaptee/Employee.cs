using System.Xml.Serialization;

namespace AdapterPattern.Adaptee;

[Serializable]
public class Employee
{
    [XmlAttribute]
    public int Id { get; set; }
    [XmlAttribute]
    public string Name { get; set; }

    public Employee()
    {

    }

    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
