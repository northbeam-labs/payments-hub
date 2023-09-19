using Api.Models;

namespace Api.Services;

public class NotificationService
{
    private readonly List<Notification> _items = new();
    private int _seq = 1;
    public IEnumerable<Notification> All() => _items;
    public Notification? Get(int id) => _items.FirstOrDefault(x => x.Id == id);
    public Notification Create(Notification x) { x.Id = _seq++; _items.Add(x); return x; }
}
