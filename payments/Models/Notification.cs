namespace Api.Models;

public class Notification
{
    public int Id { get; set; }
    public string Kind { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public bool Read { get; set; }
}
