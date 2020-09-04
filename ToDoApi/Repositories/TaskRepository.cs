using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoDataAccess.Interfaces;
using ToDoDataAccess.Models;

namespace ToDoDataAccess.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public void AddTask(Task newTask)
        {
            using (var dbContext = new ToDoContext())
            {
                dbContext.Tasks.Add(newTask);
                dbContext.SaveChanges();
            }
        }

        public void DeleteTask(int id)
        {
            using (var db = new ToDoContext())
            {
                var item = db.Tasks.FirstOrDefault(x => x.Id == id);
                db.Tasks.Remove(item);
                db.SaveChanges();
            }
        }

        public void EditTask(int id, Task task)
        {
            using (var db = new ToDoContext())
            {
                var existTask = db.Tasks.Single(x => x.Id == id);
                existTask.Name = task.Name;
                existTask.State = task.State;
                db.SaveChanges();
            }
        }

        public List<Task> GetAllTasks()
        {
            using (var dbContext = new ToDoContext())
            {
                return dbContext.Tasks.ToList();
            }
        }
    }
}
