using Microsoft.AspNetCore.Mvc;
using Api.Models;
using Api.Services;

namespace Api.Controllers;

[ApiController]
[Route("api_keys")]
public class ApiKeyController : ControllerBase
{
    private readonly ApiKeyService _svc;
    public ApiKeyController(ApiKeyService svc) => _svc = svc;
    [HttpGet] public IActionResult All() => Ok(_svc.All());
    [HttpGet("{id}")] public IActionResult Get(int id) => _svc.Get(id) is {} x ? Ok(x) : NotFound();
    [HttpPost] public IActionResult Create(ApiKey x) => Ok(_svc.Create(x));
}
