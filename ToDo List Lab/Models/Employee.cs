using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ToDo_List_Lab.Models
{
    public class Employee
    {
        [Key] //- the key shows that is the primary key
        public int Id { get; set; }
        public string Name { get; set; }
        public  float HoursAvailable { get; set; } // the properties must match the data types that exist in SQL
        public string Title { get; set; }


    }
}
