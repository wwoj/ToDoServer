using System;
using System.Collections.Generic;
using System.Text;
using ToDoDataAccess.Models;

namespace ToDoDataAccess.Interfaces
{
    public interface ITaskRepository
    {
        List<Task> GetAllTasks();
        void AddTask(Task newTask);
        void EditTask(int id, Task task);

        void DeleteTask(int id);
    }
}
