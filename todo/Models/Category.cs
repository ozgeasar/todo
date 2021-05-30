using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<TodoItem> TodoItems { get; set; }
    }
}
