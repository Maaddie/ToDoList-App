using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ToDo_List_Lab.Models
{
    public class ToDo
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }
        public float HoursNeeded { get; set; }
        public bool IsCompleted { get; set; }
    }
}
