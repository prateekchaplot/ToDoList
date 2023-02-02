using System.ComponentModel.DataAnnotations;

namespace ToDoList.API.Dtos;

public class CreateTaskDto
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
}