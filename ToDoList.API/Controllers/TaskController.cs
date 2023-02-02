using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ToDoList.API.Dtos;
using ToDoList.Data.Models;
using ToDoList.Data.Repositories;

namespace ToDoList.API.Controllers;

[ApiController]
[Route("tasks")]
public class TaskController : ControllerBase
{
    private readonly IRepository<TaskItem> _taskRepository;
    private readonly IMapper _mapper;

    public TaskController(IRepository<TaskItem> taskRepository, IMapper mapper)
    {
        _taskRepository = taskRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetTasks()
    {
        var items = await _taskRepository.GetAllAsync();
        var result = _mapper.Map<TaskItemDto[]>(items);
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetTask(int id)
    {
        var item = await _taskRepository.FirstOrDefaultAsync(x => x.Id == id);
        if (item == null)
            return NotFound();
            
        return Ok(_mapper.Map<TaskItemDto>(item));
    }

    [HttpPost]
    public async Task<IActionResult> AddTask(TaskItemDto dto)
    {
        var itemToCreate = _mapper.Map<TaskItem>(dto);
        var createdItem = await _taskRepository.AddAsync(itemToCreate);
        return CreatedAtAction(nameof(GetTask), new { createdItem.Id }, _mapper.Map<TaskItemDto>(createdItem));
    }
}