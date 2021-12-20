using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ToDo_List_Lab.Models
{
    //This is the model for our many to many relationship
    //Each employee can have multiple To Dos
    //Each To Do can have multiple employees
    //Each row in this table links a To Do to an Employee
    public class Assignment
    {
        [Key] 
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ToDoId { get; set; }

        //these two use the classes we created within the Models
        public Employee Employee { get; set; }
        public ToDo ToDo { get; set; }

        
    }
}
