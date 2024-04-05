
using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Contracts.BuberBreakfast;
using BuberBreakfast.Models;

namespace BuberBreakfast.Controllers;

[ApiController]
[Route("breakfasts")]
public class BreakfastsController : ControllerBase
{
    [HttpPost()]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {   
        // var breakfast = new Breakfast(
        //     Guid.NewGuid(),
        //     request.Name,
        //     request.Description,
        //     request.StartDateTime,
        //     request.EndDateTme,
        //     DateTime.UtcNow,
        //     request.Savory,
        //     request.Sweet
        // );
        return Ok(request);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetBreakfast(Guid id)
    {
        return Ok(id);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request)
    {
        return Ok(request);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteBreakfast(Guid id)
    {
        return Ok(id);
    }
}