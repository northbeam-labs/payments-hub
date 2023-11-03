using Api.Models;

namespace Api.Services;

public class AuditLogService
{
    private readonly List<AuditLog> _items = new();
    private int _seq = 1;
    public IEnumerable<AuditLog> All() => _items;
    public AuditLog? Get(int id) => _items.FirstOrDefault(x => x.Id == id);
    public AuditLog Create(AuditLog x) { x.Id = _seq++; _items.Add(x); return x; }
}
