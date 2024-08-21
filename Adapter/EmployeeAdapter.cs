using AdapterPattern.Adaptee;
using AdapterPattern.Target;
using Newtonsoft.Json;
using System.Xml;

namespace AdapterPattern.Adapter;

public class EmployeeAdapter : EmployeeManager, IEmployee
{
    public override string GetAllEmployees()
    {
        var returnedXml = base.GetAllEmployees();
        var doc = new XmlDocument();
        doc.LoadXml(returnedXml);

        var jsonFormattedValue = JsonConvert.SerializeObject(doc, Newtonsoft.Json.Formatting.Indented );

        Console.WriteLine( jsonFormattedValue );
        return jsonFormattedValue;
    }
}
