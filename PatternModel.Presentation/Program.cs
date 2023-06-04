// See https://aka.ms/new-console-template for more information
using PatternModel.AccessData;
using PatternModel.AccessData.BuilderPattern;
using PatternModel.Shared.Models;

EmployeeRegistry registry = EmployeeRegistry.GetInstance();

Console.WriteLine("Bienvenidio al sistema de registro de empleados");
Console.WriteLine("Digite el nombre del empleado: "); var name = Console.ReadLine();
Console.WriteLine("Digite el apellido del empleado: "); var lastName = Console.ReadLine();
Console.WriteLine("Digite la identificacion del empleado: "); var identification = Console.ReadLine();
Console.WriteLine("Digite el cargo del empleado: "); var position = Console.ReadLine();

IEmployeeBuilder builder = new EmployeeBuilder();
builder.SetName(name!);
builder.SetLastName(lastName!);
builder.SetIdentification(identification!);
builder.SetPosition(position!);
Employee newEmployee = builder.Build();

registry.InsertEmployee(newEmployee);

Console.WriteLine($"Se inserto correctamente a {newEmployee.Name} {newEmployee.LastName} Identificacion# {newEmployee.Identification} para el cargo de {newEmployee.Position}");