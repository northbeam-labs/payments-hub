namespace Api.Models;

public class Comment
{
    public int Id { get; set; }
    public string Body { get; set; } = string.Empty;
    public int AuthorId { get; set; }
    public bool Edited { get; set; }
}
