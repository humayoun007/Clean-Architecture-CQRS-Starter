using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Domain
{
    public interface IToDoRepository
    {
        Task<List<ToDoItem>> GetAllAsync();
        Task<int> CreateAsync(ToDoItem item);
    }
}
