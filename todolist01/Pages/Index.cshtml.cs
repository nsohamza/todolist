using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using todolist01.Services;
using todolist01.Model;


namespace todolist01.Pages
{
    public class IndexModel:PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileTodoService TodoService;

        public IEnumerable<Todo> Todo { get; private set; }

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonFileTodoService todoService)
        {
            _logger = logger;
            TodoService = todoService;

        }

        public void OnGet()
        {
            Todo = (IEnumerable<Todo>)TodoService.GetTodo();


        }
    }
}
    


