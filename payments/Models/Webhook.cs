namespace Api.Models;

public class Webhook
{
    public int Id { get; set; }
    public string Url { get; set; } = string.Empty;
    public string Event { get; set; } = string.Empty;
    public bool Active { get; set; }
    public string Secret { get; set; } = string.Empty;
}
