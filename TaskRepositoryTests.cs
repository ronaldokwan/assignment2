using NUnit.Framework;

namespace assignment2.Tests
{
    [TestFixture]
    public class TaskRepositoryTests
    {
        private ITaskRepository _repo;

        [SetUp]
        public void Setup()
        {
            _repo = new FileRepository();
        }

        [Test]
        public void SaveTask_AddsNewTaskSuccessfully()
        {
            // Arrange
            string title = "TestTask";
            string desc = "Test Desc";
            string status = "ToDo";
            string user = "testuser";
            string history = "";
            string dueDate = "2025-10-20";
            bool priority = false;

            // Act
            _repo.SaveTask(title, desc, status, user, history, dueDate, priority);

            // Assert
            var tasks = _repo.LoadTasks();
            Assert.That(tasks.Any(t => t.StartsWith(title + "|")), Is.True);
        }
    }
}