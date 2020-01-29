using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TODOApp.Models;
using TODOApp.ViewModels;

namespace TODOApp.Controllers
{
    public class ToDoController : Controller
    {
            
        // GET: ToDo
        public ActionResult index()
        {
            List<ToDo> todos = TodoData.GetAll();

            return View(todos);
        }

        public ActionResult Add()
        {
            AddTodoViewModel AddTodoViewModel = new AddTodoViewModel();
            return View(AddTodoViewModel);
        }

        [HttpPost]
        public ActionResult Add(AddTodoViewModel AddTodoViewModel)
        {
            ToDo newTodo = new ToDo
            {
                Name = AddTodoViewModel.Name,
                Description = AddTodoViewModel.Description
            };
            TodoData.Add(newTodo);

            return Redirect("/ToDo");
        }

        public ActionResult Remove()
        {
            ViewBag.title = "Remove Todos";
            ViewBag.todos = TodoData.GetAll();
            return View();
        }

        [HttpPost]
        public ActionResult Remove(int[] todosIds)
        {
            foreach(int todoId in todosIds)
            {
                TodoData.Remove(todoId);
            }

            return Redirect("/");
        }
    }
}