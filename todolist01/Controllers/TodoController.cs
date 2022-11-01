using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using todolist01.Model;
using todolist01.Models;
using todolist01.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace todolist01.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        public TodoController(JsonFileTodoService TodoService) => this.TodoService = TodoService;

        public JsonFileTodoService TodoService { get; }

        [HttpGet]
        public IEnumerable<Todo> Get() => TodoService.GetTodo();

       /* [HttpPost]

        public async IActionResult Add(AddTodoList addTodoList)
        {
            var todo = new Todo()
            {
                name = addTodoList.name,

            };
            await TodoService.Todo.AddAsync(todo);
        }*/
    }

    
}






