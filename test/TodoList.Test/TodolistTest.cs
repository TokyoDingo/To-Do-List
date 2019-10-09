using System;
using Xunit;

namespace TodoList.Test
{
    public class TodolistTest
    {
        [Fact]
        public void getSingleTodoItem()
        {
            Todolist todoList = new Todolist();

            todoList.add(Todoitem.Priority.High, "This is a test.");

            Assert.Equal("This is a test.", todoList.getNextTodoItem());
        }

        [Fact]
        public void getHighPriorityAddedAfterMediumPriority()
        {
            Todolist todoList = new Todolist();

            todoList.add(Todoitem.Priority.Medium, "Medium");
            todoList.add(Todoitem.Priority.High, "High");

            Assert.Equal("High", todoList.getNextTodoItem());
        }

        [Fact]
        public void getMediumPriorityAddedAfterLowPriority()
        {
            Todolist todoList = new Todolist();

            todoList.add(Todoitem.Priority.Low, "Low");
            todoList.add(Todoitem.Priority.Medium, "Medium");

            Assert.Equal("Medium", todoList.getNextTodoItem());
        }

        [Fact]
        public void getHighPriorityAddedAfterLowPriority()
        {
            Todolist todoList = new Todolist();

            todoList.add(Todoitem.Priority.Low, "Low");
            todoList.add(Todoitem.Priority.High, "High");

            Assert.Equal("High", todoList.getNextTodoItem());
        }

        [Fact]
        public void getHighPriorityAddedBeforeLowPriority()
        {
            Todolist todoList = new Todolist();

            todoList.add(Todoitem.Priority.High, "High");
            todoList.add(Todoitem.Priority.Low, "Low");

            Assert.Equal("High", todoList.getNextTodoItem());
        }

        [Fact]
        public void getEarlierWithSamePriority()
        {
            Todolist todoList = new Todolist();

            todoList.add(Todoitem.Priority.Low, "Earlier");
            todoList.add(Todoitem.Priority.Low, "Later");

            Assert.Equal("Earlier", todoList.getNextTodoItem());
        }
    }
}
