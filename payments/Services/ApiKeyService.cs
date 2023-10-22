using Api.Models;

namespace Api.Services;

public class ApiKeyService
{
    private readonly List<ApiKey> _items = new();
    private int _seq = 1;
    public IEnumerable<ApiKey> All() => _items;
    public ApiKey? Get(int id) => _items.FirstOrDefault(x => x.Id == id);
    public ApiKey Create(ApiKey x) { x.Id = _seq++; _items.Add(x); return x; }
}
