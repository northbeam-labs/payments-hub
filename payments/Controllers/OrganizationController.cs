using Microsoft.AspNetCore.Mvc;
using Api.Models;
using Api.Services;

namespace Api.Controllers;

[ApiController]
[Route("organizations")]
public class OrganizationController : ControllerBase
{
    private readonly OrganizationService _svc;
    public OrganizationController(OrganizationService svc) => _svc = svc;
    [HttpGet] public IActionResult All() => Ok(_svc.All());
    [HttpGet("{id}")] public IActionResult Get(int id) => _svc.Get(id) is {} x ? Ok(x) : NotFound();
    [HttpPost] public IActionResult Create(Organization x) => Ok(_svc.Create(x));
}
