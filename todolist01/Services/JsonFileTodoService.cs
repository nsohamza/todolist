using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using todolist01.Model;

namespace todolist01.Services
{
    public class JsonFileTodoService
    {
        //Iwebhostenvironment ==
        // intialize webhosting environment
        public JsonFileTodoService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }

        // läser in json fil som ligger
        private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath,
        "Data", "Todo.json");

        // Ienumerable = 
        public IEnumerable<Todo> GetTodo()
        {
            using var jsonFileReader = File.OpenText(JsonFileName);
            return JsonSerializer.Deserialize<Todo[]>(jsonFileReader.ReadToEnd(),
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
    }
}
