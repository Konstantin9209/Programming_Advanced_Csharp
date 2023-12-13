using System;
using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }

    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        string taskName = "my first task";
        DateTime taskDate = DateTime.Today;
        this._toDoList.AddTask(taskName, taskDate);

        string result = this._toDoList.DisplayTasks();

        Assert.That(result, Does.Contain("[ ] my first task - Due:"));

    }


    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        string taskName = "my first task";
        DateTime taskDate = DateTime.Today;
        this._toDoList.AddTask(taskName, taskDate);
        this._toDoList.CompleteTask(taskName);
        string result = this._toDoList.DisplayTasks();

        Assert.That(result, Does.Contain("[✓] my first task - Due:"));
    }


    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        string title = "Nonexistent Task";
        var ex = Assert.Throws<ArgumentException>(() => _toDoList.CompleteTask(title));
        Assert.That(ex.Message, Is.EqualTo("Task with given title does not exist."));
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        string expected = "To-Do List:";
        string actual = _toDoList.DisplayTasks();
        Assert.AreEqual(expected, actual, "Display should match the expected format for an empty task list.");
    }


[Test]
public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
{
    _toDoList.AddTask("Task 1", DateTime.Now.AddDays(1));
    _toDoList.AddTask("Task 2", DateTime.Now.AddDays(2));

    string display = _toDoList.DisplayTasks();
    string expectedFormat = "[ ] Task 1 - Due: " + DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");

    Assert.IsTrue(display.Contains(expectedFormat), "Display should contain the task in the expected format.");
}

}
