using MotoApp.Entities;
using MotoApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp
{
    public class App : IApp
    {
        private readonly IRepository<Employee> _employeesRepository;

        public App(IRepository<Employee> employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }
        public void Run()
        {
            Console.WriteLine("I'm here in Run()");

            //adding
            var employees = new[]
            {
               new Employee { FirstName = "Adam"},
               new Employee { FirstName = "Piotr"},
               new Employee { FirstName = "Zuzia"}
            };

            foreach(var emp in employees)
            {
                _employeesRepository.Add(emp);
            }

            _employeesRepository.Save();

            //reading
            var items = _employeesRepository.GetAll();

            foreach(var item in items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
