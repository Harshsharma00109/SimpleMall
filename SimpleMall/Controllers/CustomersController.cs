using Microsoft.AspNetCore.Mvc;
using SimpleMallAPI.DTOs;
using SimpleMallAPI.Models;
using SimpleMallAPI.Repositories.Interfaces;


namespace SimpleMallAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomersController : ControllerBase
{
    private readonly ICustomerRepository _repo;

    public CustomersController(ICustomerRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_repo.GetAll());

    [HttpPost]
    public IActionResult Create(CustomerDto dto)
    {
        var Customers = new Customer { Name = dto.Name, Email = dto.Email };
        _repo.Add(Customers);
        return Ok(Customers);
    }
}
