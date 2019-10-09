using System;
using System.Collections.Generic;

namespace TodoList
{
    public class Todoitem
    {
        public enum Priority
        {
            High = 0,
            Medium = 1,
            Low = 2
        }

        string description;

        Priority priority;

        DateTime whenCreated;

        public Todoitem( Priority priority, string description)
        {
            this.priority = priority;
            this.description = description;
            this.whenCreated = DateTime.Now;
        }

        public string getDescription()
        {
            return this.description;
        }

        public Priority getPriority()
        {
            return this.priority;
        }

        public DateTime getWhenCreated()
        {
            return this.whenCreated;
        }
    }
}