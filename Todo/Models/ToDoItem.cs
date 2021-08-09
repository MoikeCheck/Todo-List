using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Models
{
    public class ToDoItem
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public bool Completed { get; set; }
        public bool Delete { get; set; }
    }
}
