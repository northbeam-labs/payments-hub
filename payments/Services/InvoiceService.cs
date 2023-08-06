using Api.Models;

namespace Api.Services;

public class InvoiceService
{
    private readonly List<Invoice> _items = new();
    private int _seq = 1;
    public IEnumerable<Invoice> All() => _items;
    public Invoice? Get(int id) => _items.FirstOrDefault(x => x.Id == id);
    public Invoice Create(Invoice x) { x.Id = _seq++; _items.Add(x); return x; }
}
