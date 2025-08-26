using System;

public class Employee
{
    // Properties
    public int EmpCode { get; set; }
    public string Name { get; set; }
    public string Designation { get; set; }
    public string InstName { get; set; }
    public double BasicPay { get; set; }

    // Extra calculated properties
    public double HRA { get; private set; }
    public double DA { get; private set; }
    public double TotalPay { get; private set; }

    // Constructor to initialize values
    public Employee(int empCode, string name, string designation, string instName, double basicPay)
    {
        EmpCode = empCode;
        Name = name;
        Designation = designation;
        InstName = instName;
        BasicPay = basicPay;
    }

    // Method to calculate salary components
    public void CalculatePay()
    {
        HRA = 0.10 * BasicPay;  // 10% of Basic
        DA = 0.20 * BasicPay;   // 20% of Basic (assumed)
        TotalPay = BasicPay + HRA + DA;
    }

    // Method to display details
    public void Display()
    {
        Console.WriteLine($"Employee Code   : {EmpCode}");
        Console.WriteLine($"Name            : {Name}");
        Console.WriteLine($"Designation     : {Designation}");
        Console.WriteLine($"Institution     : {InstName}");
        Console.WriteLine($"Basic Pay       : {BasicPay}");
        Console.WriteLine($"HRA             : {HRA}");
        Console.WriteLine($"DA              : {DA}");
        Console.WriteLine($"Total Pay       : {TotalPay}");
        Console.WriteLine("--------------------------------------");
    }

    // Static method to compare two employees
    public static Employee GetHighestPaid(Employee e1, Employee e2)
    {
        return (e1.TotalPay > e2.TotalPay) ? e1 : e2;
    }
}

class Program
{
    static void Main()
    {
        // Create employee objects
        Employee emp1 = new Employee(101, "Ravi Kumar", "Manager", "ABC Corp", 40000);
        Employee emp2 = new Employee(102, "Sita Sharma", "Engineer", "XYZ Ltd", 45000);

        // Calculate pay
        emp1.CalculatePay();
        emp2.CalculatePay();

        // Display employee details
        Console.WriteLine("Employee 1 Details:");
        emp1.Display();

        Console.WriteLine("Employee 2 Details:");
        emp2.Display();

        // Find employee with highest pay
        Employee highestPaid = Employee.GetHighestPaid(emp1, emp2);
        Console.WriteLine("Employee with Highest Total Pay:");
        highestPaid.Display();
    }
}
