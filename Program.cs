using AdapterPattern.Adapter;
using AdapterPattern.Target;

namespace AdapterPattern;

public class Program
{
    public static void Main(String[] args)
    {
        var emp = new EmployeeAdapter();
        var value = emp.GetAllEmployees();
        
        Console.WriteLine(value);        
        Console.ReadLine();
    }
}