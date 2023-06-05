using Api.Models;

namespace Api.Services;

public class OrganizationService
{
    private readonly List<Organization> _items = new();
    private int _seq = 1;
    public IEnumerable<Organization> All() => _items;
    public Organization? Get(int id) => _items.FirstOrDefault(x => x.Id == id);
    public Organization Create(Organization x) { x.Id = _seq++; _items.Add(x); return x; }
}
