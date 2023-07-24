using Api.Models;

namespace Api.Services;

public class CommentService
{
    private readonly List<Comment> _items = new();
    private int _seq = 1;
    public IEnumerable<Comment> All() => _items;
    public Comment? Get(int id) => _items.FirstOrDefault(x => x.Id == id);
    public Comment Create(Comment x) { x.Id = _seq++; _items.Add(x); return x; }
}
