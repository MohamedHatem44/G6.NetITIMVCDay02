using G6.NetITIMVCDay02.Models;
using Microsoft.AspNetCore.Mvc;

namespace G6.NetITIMVCDay02.Controllers
{
    public class DepartmentController : Controller
    {
        /*----------------------------------------------------------------*/
        // DataBase
        static List<Department> _Departments = new List<Department>()
        {
            new Department { Id = 1, Name = "HR" },
            new Department { Id = 2, Name = "PR" },
            new Department { Id = 3, Name = "social Media" },
            new Department { Id = 4, Name = "Finance" },
        };
        /*----------------------------------------------------------------*/
        // Get All Department
        public IActionResult GetAll()
        {
            // View Model To pass data from Action to View
            return View(_Departments);
        }
        /*----------------------------------------------------------------*/
        public IActionResult ViewDetails(int id)
        {
            var _Department = _Departments.FirstOrDefault(d => d.Id == id);
            return View(_Department);
        }
        /*----------------------------------------------------------------*/
        // Return Create View
        public IActionResult Create()
        {
            return View();
        }
        /*----------------------------------------------------------------*/
        // Actual Create New Department
        public IActionResult ActualCreate(Department department)
        {
            _Departments.Add(department);
            return RedirectToAction("GetAll");
        }
        /*----------------------------------------------------------------*/
    }
}
