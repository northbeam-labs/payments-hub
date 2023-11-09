using Microsoft.AspNetCore.Mvc;
using Api.Models;
using Api.Services;

namespace Api.Controllers;

[ApiController]
[Route("audit_logs")]
public class AuditLogController : ControllerBase
{
    private readonly AuditLogService _svc;
    public AuditLogController(AuditLogService svc) => _svc = svc;
    [HttpGet] public IActionResult All() => Ok(_svc.All());
    [HttpGet("{id}")] public IActionResult Get(int id) => _svc.Get(id) is {} x ? Ok(x) : NotFound();
    [HttpPost] public IActionResult Create(AuditLog x) => Ok(_svc.Create(x));
}
