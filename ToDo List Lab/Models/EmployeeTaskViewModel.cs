using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo_List_Lab.Models
{
    public class EmployeeTaskViewModel
    {
        //A View Model is a model created specifically only to exist on views
        //Commonly they are used to show off multiple model classes at once
        //Or to move around small pieces of data from the controller to the view
        public List<ToDo> ToDos { get; set; } = new List<ToDo>();
        public List<Employee> Employees {get;set;}

        //In the constructor we listed both DALs . both of the lists are nested inside of one object.
        //so basically we're taking the models and putting them into a new object and we list them in the constructor which will help display them
        public EmployeeTaskViewModel()
        {
            //We will use both our DALs to fill out this model
            ToDoDAL tdDal = new ToDoDAL();
            EmployeeDAL eDAL = new EmployeeDAL();
            ToDos = tdDal.GetToDos();
            Employees = eDAL.GetEmployees();

        }
    }
}
