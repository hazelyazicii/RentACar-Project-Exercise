using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BrandsController : ControllerBase
{
    private readonly IBrandService _brandService;

    public BrandsController()
    {
        // Her HTTP Request i�in yeni bir Controller nesnesi olu�turulur.
        _brandService = ServiceRegistration.BrandService;
        // Daha sonra IoC Container yap�m�z� kurdu�umuz Dependency Injection ile daha verimli hale getiricez.
    }

    //[HttpGet]
    //public ActionResult<string> //IActionResult
    //GetList()
    //{
    //    return Ok("BrandsController");
    //}

    [HttpGet] // GET http://localhost:5245/api/brands
    public ICollection<Brand> GetList()
    {
        IList<Brand> brandList = _brandService.GetList();
        return brandList;
    }

    //[HttpPost("/add")] // POST http://localhost:5245/api/brands/add
    [HttpPost] // POST http://localhost:5245/api/brands
    public Brand Add(Brand addBrandRequest)
    {
        Brand addedBrand = _brandService.Add(addBrandRequest);
        return addedBrand;
    }
}