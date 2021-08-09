using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Models;

namespace Todo
{
    public class DataBase : DbContext
    {
        public DataBase(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ToDoItem> ToDos { get; set; }
    }
}