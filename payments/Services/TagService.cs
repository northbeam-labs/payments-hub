using Api.Models;

namespace Api.Services;

public class TagService
{
    private readonly List<Tag> _items = new();
    private int _seq = 1;
    public IEnumerable<Tag> All() => _items;
    public Tag? Get(int id) => _items.FirstOrDefault(x => x.Id == id);
    public Tag Create(Tag x) { x.Id = _seq++; _items.Add(x); return x; }
}
