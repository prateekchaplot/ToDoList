using System.ComponentModel.DataAnnotations;

namespace ToDoList.API.Dtos;

public class TaskItemDto
{
    public int Id { get; set; }

    [Required]
    [MinLength(5)]
    [MaxLength(25)]
    public string Title { get; set; }
    
    [Required]
    [MinLength(10)]
    [MaxLength(250)]
    public string Description { get; set; }
    
    [Required]
    public DateTime DueDate { get; set; }
    
    public bool IsCompleted { get; set; }
    
    public string Status { get; set; }
}