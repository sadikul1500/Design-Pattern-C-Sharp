using System.Xml;
using System.Xml.Serialization;

namespace AdapterPattern.Adaptee;

public class EmployeeManager
{
    public List<Employee> Employees { get; set; }

    public EmployeeManager()
    {
        Employees =
        [
            new Employee { Id = 1, Name = "Abu Sayed"},
            new Employee { Id = 2, Name = "Mir Mugdho"},
            new Employee { Id = 3, Name = "Rafi"},
        ];
    }

    public virtual string GetAllEmployees()
    {
        var emptyNameSpaces = new XmlSerializerNamespaces([XmlQualifiedName.Empty]);
        var serializer = new XmlSerializer(Employees.GetType());
        var settings = new XmlWriterSettings
        {
            Indent = true,
            OmitXmlDeclaration = true
        };

        using var stream = new StringWriter();
        using var writer = XmlWriter.Create(stream, settings);
        serializer.Serialize(writer, Employees, emptyNameSpaces);
        return stream.ToString();
    }
}
