using System.Collections.Generic;
using ToDoList.DataModel;

namespace ToDoList.Services
{
    public class ToDoListService
    {
        public IEnumerable<ToDoItem> GetItems()
        {
            // Returning an empty list since items are now loaded from file
            return new List<ToDoItem>();
        }
    }
}
