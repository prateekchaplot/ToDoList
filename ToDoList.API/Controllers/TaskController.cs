using Microsoft.AspNetCore.Mvc;
using ToDoList.Data.Models;
using ToDoList.Data.Repositories;

namespace ToDoList.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{
    private readonly IRepository<TaskItem> _taskRepository;

    public TaskController(IRepository<TaskItem> taskRepository)
    {
        _taskRepository = taskRepository;
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetTasks()
    {
        var items = await _taskRepository.GetAllAsync();
        return Ok(items);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> AddTask(TaskItem taskItem)
    {
        var createdItem = await _taskRepository.AddAsync(taskItem);
        return Ok(createdItem);
    }
}