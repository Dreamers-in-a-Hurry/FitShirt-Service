using FitShirt.Domain.Designing.Models.Queries;
using FitShirt.Domain.Designing.Models.Responses;
using FitShirt.Domain.Designing.Services;
using FitShirt.Presentation.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitShirt.Presentation.Designing.Controllers;

[ApiController]
[Route("api/v1/shields")]
[Produces("application/json")]
public class ShieldController : ControllerBase
{
    private readonly IShieldQueryService _shieldQueryService;

    public ShieldController(IShieldQueryService shieldQueryService)
    {
        _shieldQueryService = shieldQueryService;
    }

    /// GET: /api/v1/shields
    /// <summary>
    /// Get a shields list.
    /// </summary>
    [HttpGet]
    [AllowAnonymous]
    [ProducesResponseType(typeof(IReadOnlyCollection<ShieldResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(void), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(CodeErrorResponse), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(CodeErrorResponse), StatusCodes.Status500InternalServerError)]

    public async Task<IActionResult> GetShieldsAsync()
    {
        var query = new GetAllShieldQuery();
        var result = await _shieldQueryService.Handle(query);

        return Ok(result);
    }

    /// GET: /api/v1/shields/{id}
    /// <summary>
    /// Get a shield by its id.
    /// </summary>
    [HttpGet("{id}")]
    [AllowAnonymous]
    [ProducesResponseType(typeof(DesignResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(void), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(CodeErrorResponse), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(CodeErrorResponse), StatusCodes.Status500InternalServerError)]

    public async Task<IActionResult> GetShieldByIdAsync(int id)
    {
        var query = new GetShieldByIdQuery(id);
        var result = await _shieldQueryService.Handle(query);

        return Ok(result);
    }
    
    
}