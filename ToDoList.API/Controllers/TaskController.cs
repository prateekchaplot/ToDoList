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
        var result = _mapper.Map<ReadTaskDto[]>(items);
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetTask(int id)
    {
        var item = await _taskRepository.FirstOrDefaultAsync(x => x.Id == id);
        if (item == null)
            return NotFound();
            
        return Ok(_mapper.Map<ReadTaskDto>(item));
    }

    [HttpPost]
    public async Task<IActionResult> AddTask(CreateTaskDto dto)
    {
        var itemToCreate = _mapper.Map<TaskItem>(dto);
        var createdItem = await _taskRepository.AddAsync(itemToCreate);
        return CreatedAtAction(nameof(GetTask), new { createdItem.Id }, _mapper.Map<ReadTaskDto>(createdItem));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTask(int id, UpdateTaskDto dto)
    {
        var item = await _taskRepository.FirstOrDefaultAsync(x => x.Id == id);
        if (item == null)
            return NotFound();
        
        item.Title = dto.Title;
        item.Description = dto.Description;
        item.DueDate = dto.DueDate;
        item.IsCompleted = dto.IsCompleted;
        item.Status = dto.Status;

        await _taskRepository.UpdateAsync(item);
        return Ok(_mapper.Map<ReadTaskDto>(item));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var item = await _taskRepository.FirstOrDefaultAsync(x => x.Id == id);
        if (item == null)
            return NotFound();
        
        await _taskRepository.DeleteAsync(item);
        return NoContent();
    }
}