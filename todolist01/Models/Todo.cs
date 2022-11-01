using System;
using System.Collections.Generic;
using System.Text.Json;

namespace todolist01.Model
{
    public class Todo
    {
        public int id { get; set; }
        public string name { get; set; }
       
        public override string ToString()
            => JsonSerializer.Serialize<Todo>(this);

    }
}
