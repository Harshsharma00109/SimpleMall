using Microsoft.AspNetCore.Mvc;
using SimpleMallAPI.DTOs;
using SimpleMallAPI.Models;
using SimpleMallAPI .Repositories;
using SimpleMallAPI.Repositories.Interfaces;


namespace SimpleMallAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductRepository _repo;

    public ProductsController(IProductRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_repo.GetAll());

    [HttpPost]
    public IActionResult Create(ProductDto dto)
    {
        var product = new Product { Name = dto.Name, Price = dto.Price };
        _repo.Add(product);
        return Ok(product);
    }
}
