namespace ToDoList.API.Dtos;

public class ReadTaskDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; } = false;
    public string Status { get; set; }
}