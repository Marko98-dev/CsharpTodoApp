using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TODOApp.Models
{
    public class TodoData
    {
        private static List<ToDo> todos = new List<ToDo>();

        // GetAll Method

        public static List<ToDo> GetAll ()
        {
            return todos;
        }

        // Add Method

        public static void Add (ToDo newTodo)
        {
            todos.Add(newTodo);
        }

        // Remove Method

        public static void Remove (int id)
        {
            ToDo todoToRemove = GetById(id);
            todos.Remove(todoToRemove);
        }

        // GetById Method
        
        public static ToDo GetById(int id)
        {
            return todos.Single(x => x.TodoId == id);
        }
    }
}