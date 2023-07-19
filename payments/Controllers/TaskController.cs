using Microsoft.AspNetCore.Mvc;
using Api.Models;
using Api.Services;

namespace Api.Controllers;

[ApiController]
[Route("tasks")]
public class TaskController : ControllerBase
{
    private readonly TaskService _svc;
    public TaskController(TaskService svc) => _svc = svc;
    [HttpGet] public IActionResult All() => Ok(_svc.All());
    [HttpGet("{id}")] public IActionResult Get(int id) => _svc.Get(id) is {} x ? Ok(x) : NotFound();
    [HttpPost] public IActionResult Create(Task x) => Ok(_svc.Create(x));
}
