using System.Collections.Generic;

namespace ToDoList.Models
{
    public class TodoViewModel
    {
        public List<TodoItem> TodoList { get; set; } = new List<TodoItem>();
        public TodoItem Todo { get; set; } = new TodoItem();
    }
}