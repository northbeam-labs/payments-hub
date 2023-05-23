using Api.Models;

namespace Api.Services;

public class UserService
{
    private readonly List<User> _items = new();
    private int _seq = 1;
    public IEnumerable<User> All() => _items;
    public User? Get(int id) => _items.FirstOrDefault(x => x.Id == id);
    public User Create(User x) { x.Id = _seq++; _items.Add(x); return x; }
}
