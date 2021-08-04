using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo
{
    public static class TodoItems 
    {
        public static IList<TodoItem> Items { get; set; } = new List<TodoItem>();
    }
    public class TodoItem
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public bool Completed { get; set; }
        public bool Delete { get; set; }
    }
}
