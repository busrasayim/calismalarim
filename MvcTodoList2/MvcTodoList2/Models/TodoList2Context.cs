using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcTodoList2.Models
{
    public class TodoList2Context :DbContext
    {
        public DbSet<TaskItem> TaskItems { get; set; }
    }
}