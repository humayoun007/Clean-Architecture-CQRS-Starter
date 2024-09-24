using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain;

namespace ToDoApp.Application
{
    public class CreateToDoItemCommandHandler(IToDoRepository toDoRepository) :
        IRequestHandler<CreateToDoItemCommand, int>
    {
        public Task<int> Handle(CreateToDoItemCommand request, CancellationToken cancellationToken)
        {
            var item = new ToDoItem { Description = request.Description };
            return toDoRepository.CreateAsync(item);
        }
    }
}
