
using ConceptsPoo;

Console.WriteLine("Hello, World!");

Console.WriteLine("=====================================");

Employee employee1 = new BaseCommissionEmployee()
{
    Id = 0101,
    FirstName = "Martinez",
    LastName = "Jorge Edgardo",
    BirthDate = new Date(1985, 4, 23),
    HiringDate = new Date(2011, 1, 1),
    IsActive = true,
    Base = 860678.45M,
    Sales = 580000000M,
    CommissionPercentaje = 0.015F
};
//Console.WriteLine(employee1);

ICollection<Employee> employees = new List<Employee>()
{ 
    employee1 
};  
decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                               ===================");
Console.WriteLine($"TOTAL                          {$"{payroll:C2}",15}");

Invoice invoice1 = new Invoice()
{
    Description = "Iphone 13",
    Id = 1,
    Price = 530000,
    Quantity = 17.5F
};
Console.WriteLine(invoice1);
Console.Read();