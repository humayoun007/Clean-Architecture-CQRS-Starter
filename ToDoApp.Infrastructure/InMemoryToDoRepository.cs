using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain;

namespace ToDoApp.Infrastructure
{
    public class InMemoryToDoRepository : IToDoRepository
    {
        private static readonly List<ToDoItem> _items = [];
        public Task<int> CreateAsync(ToDoItem item)
        {
            _items.Add(item);
            return Task.FromResult(item.Id);
        }

        public Task<List<ToDoItem>> GetAllAsync()
        {
            return Task.FromResult(_items);
        }
    }
}
