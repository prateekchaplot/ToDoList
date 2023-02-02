namespace ToDoList.Data.Models;

public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }
    public TASK_STATUS Status { get; set; }
}

public enum TASK_STATUS
{
    TODO,
    IN_PROGRESS,
    DONE
}