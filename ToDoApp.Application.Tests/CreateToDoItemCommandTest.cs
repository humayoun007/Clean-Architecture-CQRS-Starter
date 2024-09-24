using Moq;
using ToDoApp.Domain;

namespace ToDoApp.Application.Tests
{
    public class CreateToDoItemCommandTest
    {
        [Fact]
        public void GivenCreateToDoItemCommandHandler_WhenHandleCalled_ThenCreateNewToDoItem()
        {
            //arrange

            var toDoRepositoryMock = new Mock<IToDoRepository>();
            toDoRepositoryMock.Setup(x => x.CreateAsync(It.IsAny<ToDoItem>())).ReturnsAsync(1);

           var createToDoItemCommandHandler = new CreateToDoItemCommandHandler(toDoRepositoryMock.Object);

            var createToDoItemCommand = new CreateToDoItemCommand() { Description = "Test Description" };
            //act

           var result = createToDoItemCommandHandler.Handle(createToDoItemCommand, CancellationToken.None).Result;

            //assert
            Assert.Equal(1, result);

        }
    }
}