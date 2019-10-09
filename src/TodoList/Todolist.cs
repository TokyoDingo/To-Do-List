using System;
using System.Collections.Generic;

namespace TodoList
{
    class TodoitemComparer : IComparer<Todoitem> 
    { 
        public TodoitemComparer() : base()
        {

        }

        public int Compare(Todoitem x, Todoitem y) 
        {   
            if(x.getPriority() != y.getPriority())
            {   
                return x.getPriority().CompareTo(y.getPriority());
            }
            else{
                return x.getWhenCreated().CompareTo(y.getWhenCreated());
            }            
        } 
    } 

    public class Todolist
    {
        List<Todoitem> todoList;
        TodoitemComparer comparer;

        public Todolist()
        {
            todoList = new List<Todoitem>();
            comparer = new TodoitemComparer();
        }

        public void add(Todoitem.Priority priority, string description)
        {
            todoList.Add(new Todoitem(priority, description));
            todoList.Sort(comparer);
        }

        public string getNextTodoItem()
        {
            return todoList[0].getDescription();
        }

        public void printTodoList()
        {
            foreach(var item in todoList )
            {
                Console.WriteLine($"{item.getDescription()} ({item.getPriority()} entered at {item.getWhenCreated()})");
            }
        }
    }
}