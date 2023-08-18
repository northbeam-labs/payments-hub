using Microsoft.AspNetCore.Mvc;
using Api.Models;
using Api.Services;

namespace Api.Controllers;

[ApiController]
[Route("invoices")]
public class InvoiceController : ControllerBase
{
    private readonly InvoiceService _svc;
    public InvoiceController(InvoiceService svc) => _svc = svc;
    [HttpGet] public IActionResult All() => Ok(_svc.All());
    [HttpGet("{id}")] public IActionResult Get(int id) => _svc.Get(id) is {} x ? Ok(x) : NotFound();
    [HttpPost] public IActionResult Create(Invoice x) => Ok(_svc.Create(x));
}
