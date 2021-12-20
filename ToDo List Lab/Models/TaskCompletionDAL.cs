using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo_List_Lab.Models
{
    public class TaskCompletionDAL
    {
       

        public void UpdateTaskStatus(int toDoId)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"update todo set IsCompleted = 1 where id = " +toDoId;
                connect.Open();
                connect.Query<ToDo>(sql);
                connect.Close();
                //return toDo;
            }
        }
    }
}
