using Core.Models.Location;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebApiTransfer.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CountriesController(AppDbTransferContext db) : ControllerBase
{
    [HttpGet]
    public ActionResult GetCountry()
    {
        var countries = db.Countries.Where(x=> !x.IsDeleted).ToList();
        return Ok(countries); // код 200
        
    }
}