using Microsoft.AspNetCore.Mvc;
using Api.Models;
using Api.Services;

namespace Api.Controllers;

[ApiController]
[Route("comments")]
public class CommentController : ControllerBase
{
    private readonly CommentService _svc;
    public CommentController(CommentService svc) => _svc = svc;
    [HttpGet] public IActionResult All() => Ok(_svc.All());
    [HttpGet("{id}")] public IActionResult Get(int id) => _svc.Get(id) is {} x ? Ok(x) : NotFound();
    [HttpPost] public IActionResult Create(Comment x) => Ok(_svc.Create(x));
}
