using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoDataAccess.Interfaces;
using ToDoDataAccess.Models;

namespace ToDoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private ITaskRepository _taskRepository;
        public TodoController (ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_taskRepository.GetAllTasks());
        }
        [HttpPost]

        public ActionResult Add(Task task)
        {
            _taskRepository.AddTask(task);
            return Ok("Added");
        }
        [HttpPut("{id}")]

        public ActionResult EditTask(int id, Task task)
        {
            _taskRepository.EditTask(id, task);
            return Ok();
        }
        [HttpDelete("{id}")]

        public ActionResult DeleteTask(int id)
        {
            _taskRepository.DeleteTask(id);
            return Ok("Task removed");
        }
    }
}