namespace Api.Models;

public class AuditLog
{
    public int Id { get; set; }
    public string Action { get; set; } = string.Empty;
    public int ActorId { get; set; }
    public string Target { get; set; } = string.Empty;
}
