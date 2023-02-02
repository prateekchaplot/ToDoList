using AutoMapper;
using ToDoList.API.Dtos;
using ToDoList.Data.Models;

namespace ToDoList.API.Profiles;

public class TodoMapper : Profile
{
    public TodoMapper()
    {
        CreateMap<TaskItem, ReadTaskDto>();
        CreateMap<CreateTaskDto, TaskItem>();
        CreateMap<UpdateTaskDto, TaskItem>();
    }
}