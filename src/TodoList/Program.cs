using System;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Todolist todoList = new Todolist();

            //todoList.add(Todoitem.Priority.Low, "Low");
            //todoList.add(Todoitem.Priority.Medium, "Medium");

            todoList.add(Todoitem.Priority.Low, "Not important...");
            todoList.add(Todoitem.Priority.High, "Very important!");
            todoList.add(Todoitem.Priority.Medium, "Should probably do");
            todoList.add(Todoitem.Priority.High, "Also very important!");

            //todoList.add(Todoitem.Priority.Low, "First");
            //todoList.add(Todoitem.Priority.Low, "Second");

            //Console.WriteLine(todoList.getNextTodoItem());
            todoList.printTodoList();
        }
    }
}
