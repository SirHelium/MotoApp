using Microsoft.Extensions.DependencyInjection;
using MotoApp;
using MotoApp.Entities;
using MotoApp.Repositories;

var services = new ServiceCollection();
services.AddSingleton<IApp, App>();
services.AddSingleton<IRepository<Employee>, ListRepository<Employee>>();

var serviceProvider = services.BuildServiceProvider();
var app = serviceProvider.GetService<IApp>();
app.Run();




//using MotoApp.Data;
//using MotoApp.Entities;
//using MotoApp.Repositories;
//using MotoApp.Repositories.Extensions;
//using MotoApp.Entities.Extensions;


////var itemAdded = new ItemAdded<Employee>(EmployeeAdded);
//var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext(), EmployeeAdded);
//employeeRepository.ItemAdded += EmployeeRepositoryOnItemAdded;

//AddEmployees(employeeRepository);
//WriteAllToConsole(employeeRepository);

//static void EmployeeRepositoryOnItemAdded(object? sender, Employee employee)
//{
//    Console.WriteLine($"Employee added => {employee.FirstName} from {sender.GetType().Name}");
//}
//static void EmployeeAdded(Employee employee)
//{
//    Console.WriteLine($"{employee.FirstName} added");
//}

//static void AddEmployees(IRepository<Employee> employeeRepository)
//{
//    var employees = new[]
//    {
//        new Employee { FirstName = "Adam"},
//        new Employee { FirstName = "Piotr"},
//        new Employee { FirstName = "Zuzia"}
//    };

//    employeeRepository.AddBatch(employees);

//    //employeeRepository.Add(new Employee { FirstName = "Adam" });
//    //employeeRepository.Add(new Employee { FirstName = "Piotr" });
//    //employeeRepository.Add(new Employee { FirstName = "Zuzia" });
//    //employeeRepository.Save();
//}


//static void WriteAllToConsole(IReadRepository<IEntity> repository)
//{
//    var items = repository.GetAll();
//    foreach (var item in items)
//    {
//        Console.WriteLine(item);
//    }
//}

////GetEmployeeById(sqlRepository);


////static void GetEmployeeById(IRepository<IEntity> employeeRepository)
////{
////    var employee = employeeRepository.GetById(2);
////    Console.WriteLine(employee.ToString());
////}