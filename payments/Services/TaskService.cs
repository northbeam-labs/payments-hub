using Api.Models;

namespace Api.Services;

public class TaskService
{
    private readonly List<Task> _items = new();
    private int _seq = 1;
    public IEnumerable<Task> All() => _items;
    public Task? Get(int id) => _items.FirstOrDefault(x => x.Id == id);
    public Task Create(Task x) { x.Id = _seq++; _items.Add(x); return x; }
}
