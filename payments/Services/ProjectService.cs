using Api.Models;

namespace Api.Services;

public class ProjectService
{
    private readonly List<Project> _items = new();
    private int _seq = 1;
    public IEnumerable<Project> All() => _items;
    public Project? Get(int id) => _items.FirstOrDefault(x => x.Id == id);
    public Project Create(Project x) { x.Id = _seq++; _items.Add(x); return x; }
}
