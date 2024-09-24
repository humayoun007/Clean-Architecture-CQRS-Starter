using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain;

namespace ToDoApp.Application
{
    public class ToDoItemQueryHandler(IToDoRepository toDoRepository) : IRequestHandler<ToDoItemQuery, List<ToDoItem>>
    {
        public Task<List<ToDoItem>> Handle(ToDoItemQuery request, CancellationToken cancellationToken)
        {
            return toDoRepository.GetAllAsync();
        }
    }
}
