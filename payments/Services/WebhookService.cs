using Api.Models;

namespace Api.Services;

public class WebhookService
{
    private readonly List<Webhook> _items = new();
    private int _seq = 1;
    public IEnumerable<Webhook> All() => _items;
    public Webhook? Get(int id) => _items.FirstOrDefault(x => x.Id == id);
    public Webhook Create(Webhook x) { x.Id = _seq++; _items.Add(x); return x; }
}
