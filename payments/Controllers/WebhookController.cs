using Microsoft.AspNetCore.Mvc;
using Api.Models;
using Api.Services;

namespace Api.Controllers;

[ApiController]
[Route("webhooks")]
public class WebhookController : ControllerBase
{
    private readonly WebhookService _svc;
    public WebhookController(WebhookService svc) => _svc = svc;
    [HttpGet] public IActionResult All() => Ok(_svc.All());
    [HttpGet("{id}")] public IActionResult Get(int id) => _svc.Get(id) is {} x ? Ok(x) : NotFound();
    [HttpPost] public IActionResult Create(Webhook x) => Ok(_svc.Create(x));
}
