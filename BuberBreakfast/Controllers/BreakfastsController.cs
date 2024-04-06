
using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Contracts.BuberBreakfast;
using BuberBreakfast.Models;

namespace BuberBreakfast.Controllers;

[ApiController]
[Route("breakfasts")]
public class BreakfastsController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {   
        var Breakfast = new Breakfast(
            Guid.NewGuid(),
            request.Name,
            request.Description,
            request.StartDateTime,
            request.EndDateTime,
            DateTime.Now,
            request.Savory,
            request.Sweet
        );

        //TODO: Save breakfast to database

        var response = new BreakfastResponse(
            Breakfast.Id,
            Breakfast.Name,
            Breakfast.Description,
            Breakfast.StartDateTime,
            Breakfast.EndDateTime,
            Breakfast.LastModifiedDateTime,
            Breakfast.Savory,
            Breakfast.Sweet
        );
        return CreatedAtAction(
            actionName: nameof(GetBreakfast),
            routeValues: new { id = response.Id },
            value: response);
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