using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo_List_Lab.Models;

namespace ToDo_List_Lab.Controllers
{
    public class ToDoController : Controller
    {

            ToDoDAL tddb = new ToDoDAL();
        EmployeeDAL eDAL = new EmployeeDAL();
        TaskCompletionDAL tDAL = new TaskCompletionDAL();

        public IActionResult CreateToDo()
        {
            ToDo t = new ToDo();
            t.Name = "Mow Lawn";
            t.IsCompleted = false;
            t.HoursNeeded = 1.5f;

            tddb.AddToDo(t);
            return RedirectToAction("Index", "Employee");

        }

        //how to assign a task
        public IActionResult AssignTask()
        {
            EmployeeTaskViewModel em = new EmployeeTaskViewModel();
            return View(em);
        }

        [HttpPost]
        public IActionResult AssignTask(int toDoId, int employeeId)
        {
            Assignment a = new Assignment();
            a.EmployeeId = employeeId;
            a.ToDoId = toDoId;

            AssignmentDAL ad = new AssignmentDAL();
            ad.CreateAssignment(a);
            return RedirectToAction("Index", "Employee");
        }

        public IActionResult TaskIsComplete(int toDoId)
        {

            tDAL.UpdateTaskStatus(toDoId);
            return View();

        }

        public IActionResult ListToDos()
        {
            List<ToDo> todos = tddb.GetToDos();
            return View(todos);
        }
    }
}
