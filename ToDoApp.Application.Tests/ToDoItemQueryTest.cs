using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain;
using Xunit.Abstractions;

namespace ToDoApp.Application.Tests
{
    public class ToDoItemQueryTest
    {
        private readonly ITestOutputHelper output;

        public ToDoItemQueryTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public async Task GivenToDoItemQueryHandler_WhenHandleCalled_ThenReturnToDoItems()
        {
            var toDoRepositoryMock = new Mock<IToDoRepository>();
            toDoRepositoryMock.Setup(x => x.GetAllAsync()).ReturnsAsync([
                new(){Description="Item 1"},
                new() {Description = "Item 2"}
                ]);           

           var toDoItemQueryHandler =  new ToDoItemQueryHandler(toDoRepositoryMock.Object);

            var toDoItemQuery = new ToDoItemQuery();

           var result = await toDoItemQueryHandler.Handle(toDoItemQuery, CancellationToken.None);

            Assert.Equal(2, result.Count);
            Assert.Equal("Item 1", result[0].Description);
            Assert.Equal("Item 2", result[^1].Description);
        }

        [Fact]
        public void TestNumbersReversalOrder()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Access and print the last element using result[^1]
            int lastElement = numbers[^1];
            output.WriteLine("Last element: " + lastElement);

            // Modify the last element
            numbers[^1] = 100;

            // Print the modified list
            foreach (var number in numbers)
            {
                //Console.WriteLine(number);
                output.WriteLine($"number is {number}");
            }

        }
    }
}
