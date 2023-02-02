using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ToDoList.Data.Models;

namespace ToDoList.API.Dtos;

public class UpdateTaskDto
{
    [Required]
    [MinLength(5)]
    [MaxLength(50)]
    public string Title { get; set; }

    [Required]
    [MinLength(15)]
    [MaxLength(150)]
    public string Description { get; set; }
    
    [Required]
    public DateTime DueDate { get; set; }
    
    [Required]
    public bool IsCompleted { get; set; } = false;

    [Required]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TASK_STATUS Status { get; set; }
}