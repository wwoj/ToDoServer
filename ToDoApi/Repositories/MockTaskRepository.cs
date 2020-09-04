using System;
using System.Collections.Generic;
using ToDoDataAccess.Interfaces;
using ToDoDataAccess.Models;

namespace ToDoDataAccess
{
    public class MockTaskRepository : ITaskRepository
    {
        public void AddTask(Task newTask)
        {
            throw new NotImplementedException();
        }

        public void DeleteTask(int id)
        {
            throw new NotImplementedException();
        }

        public void EditTask(int id, Task task)
        {
            throw new NotImplementedException();
        }

        public List<Task> GetAllTasks()
        {
            return new List<Task>()
            {
                new Task(){ Id=1,Name="Zadanie domowe",State="Done"},
                new Task(){ Id=2,Name="Nauka React",State="In Progrss"},
                new Task(){ Id=3,Name="Przypomnienie JS",State="Not Done"}
            };
        }
    }
}
