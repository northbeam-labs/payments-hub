using Api.Models;

namespace Api.Services;

public class PaymentService
{
    private readonly List<Payment> _items = new();
    private int _seq = 1;
    public IEnumerable<Payment> All() => _items;
    public Payment? Get(int id) => _items.FirstOrDefault(x => x.Id == id);
    public Payment Create(Payment x) { x.Id = _seq++; _items.Add(x); return x; }
}
