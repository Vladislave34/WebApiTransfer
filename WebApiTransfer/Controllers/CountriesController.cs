using Core.Models.Location;
using Microsoft.AspNetCore.Mvc;

namespace WebApiTransfer.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CountriesController : ControllerBase
{
    [HttpGet]
    public ActionResult GetCountry()
    {
        var countries = new List<CountryItemModel>
        {
            new CountryItemModel 
            { 
                Id = 1, 
                Name = "United States", 
                Code = "US", 
                Slug = "united-states", 
                image = null 
            },
            new CountryItemModel 
            { 
                Id = 2, 
                Name = "Canada", 
                Code = "CA", 
                Slug = "canada", 
                image = null 
            },
            // Additional countries can be added here.
        };
        return Ok(countries); // код 200
        
    }
}