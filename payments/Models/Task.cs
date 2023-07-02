namespace Api.Models;

public class Task
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int Priority { get; set; }
    public bool Done { get; set; }
    public string DueDate { get; set; } = string.Empty;
}
