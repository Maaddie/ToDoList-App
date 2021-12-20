using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo_List_Lab.Models;

namespace ToDo_List_Lab.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDAL dbEmployee = new EmployeeDAL();
        AssignmentDAL dbAssignment = new AssignmentDAL();
        ToDoDAL dbToDo = new ToDoDAL();

        public IActionResult Index()
        {
            EmployeeTaskViewModel etvm = new EmployeeTaskViewModel();

            return View(etvm);
        }
        //public IActionResult Index()
        //{
        //    List<Employee> employees = dbEmployee.GetEmployees();
        //    return View(employees);
        //}

        public IActionResult Details(int id)
        {
            Employee e = dbEmployee.GetEmployee(id);
            return View(e);
        }
        [HttpPost]
        public IActionResult CreateEmployee(Employee e)
        {
            //Employee e = new Employee();
            //e.Name = "Cotton Hill";
            //e.Title = "Retired Vet";
            //e.HoursAvailable = 30;
            //dbEmployee.AddEmployee(e);
            dbEmployee.AddEmployee(e);
            return RedirectToAction("Index");
        }

        public IActionResult CreateEmployee()
        {
            return View();
        }

        public IActionResult UpdateEmployee(int id)
        {
            Employee e = dbEmployee.GetEmployee(id);
            return View(e);
        }

        [HttpPost]
        public IActionResult UpdateEmployee(Employee e)
        {
            dbEmployee.UpdateEmployee(e);
            return RedirectToAction("Index", "Employee");
        }

        public IActionResult DeleteEmployee(int id)
        {
            dbAssignment.DeleteAssignmentByEmployeeId(id);
            dbEmployee.DeleteEmployee(id);
            return RedirectToAction("Index", "Employee");
        }
    }
}
