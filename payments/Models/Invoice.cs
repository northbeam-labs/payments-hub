namespace Api.Models;

public class Invoice
{
    public int Id { get; set; }
    public string Number { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string Currency { get; set; } = string.Empty;
    public bool Paid { get; set; }
}
