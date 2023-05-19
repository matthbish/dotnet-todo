namespace TodoApi.Models;

public class TodoItemDTO // Data Transfer Object for TodoItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}