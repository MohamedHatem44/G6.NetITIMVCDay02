using G6.NetITIMVCDay02.Models;
using Microsoft.AspNetCore.Mvc;

namespace G6.NetITIMVCDay02.Controllers
{
    public class EmployeeController : Controller
    {
        /*----------------------------------------------------------------*/
        // DataBase
        static List<Employee> _Employees = new List<Employee>()
        {
            new Employee { Id = 1, Name = "Mohamed", Age = 30, Salary = 1234 },
            new Employee { Id = 2, Name = "Ramy", Age = 40, Salary = 2234 },
            new Employee { Id = 3, Name = "Mai", Age = 20, Salary = 3234 },
            new Employee { Id = 4, Name = "Ali", Age = 25, Salary = 4234 },
            new Employee { Id = 5, Name = "Omar", Age = 35, Salary = 5234 },
            new Employee { Id = 6, Name = "Hala", Age = 45, Salary = 6234 },
            new Employee { Id = 7, Name = "Ahmed", Age = 50, Salary = 7234 },
            new Employee { Id = 8, Name = "Mostafa", Age = 55, Salary = 8234 },
            new Employee { Id = 9, Name = "Nour", Age = 20, Salary = 9234 },
            new Employee { Id = 10, Name = "Sara", Age = 25, Salary = 10234 },
        };
        /*----------------------------------------------------------------*/
        // Get All Employees
        // http://localhost:5039/Controller/Action
        // http://localhost:5039/Employee/GetAll
        public IActionResult GetAll()
        {
            // View Bag To pass data from Action to View
            ViewBag.allEmps = _Employees;
            return View();
        }
        /*----------------------------------------------------------------*/
        // Get one Employee By Id
        public IActionResult ViewDetails(int id)
        {
            var _Employee = _Employees.FirstOrDefault(emp => emp.Id == id);
            ViewBag.oneEmp = _Employee;
            ViewBag.title = "Employee Portal";
            return View();
        }
        /*----------------------------------------------------------------*/
        // Return Create View
        public IActionResult Create()
        {
            return View();
        }
        /*----------------------------------------------------------------*/
        // Actual Create New Employee
        public IActionResult ActualCreate(int id, string name, int age, decimal salary)
        {
            Employee newEmp = new Employee { Id = id, Name = name, Age = age, Salary = salary };
            _Employees.Add(newEmp); // New Employee Obj To insert into List
            return RedirectToAction("GetAll");
        }
        /*----------------------------------------------------------------*/
    }
}
