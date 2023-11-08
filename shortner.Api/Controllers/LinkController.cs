using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using shortner.Api.ExceptionHelper;
using Shortner.BusinessLayer.Services;
using Shortner.BusinessLayer.Services.Interfaces;
using shortner.DataAccessLayer.Entites;

namespace shortner.Api.Controllers;

[ApiController]
[Route("link")]
public class LinkController : ControllerBase
{
    private ILinkService _linkService;

    public LinkController(ILinkService linkService)
    {
        _linkService = linkService;
    }

    [HttpGet]

    public async Task<IActionResult> Get(long id)
    {
        Link result;
        try
        {
            result = await _linkService.GetById(id);
        }
        catch (DataBaseException ex)
        {
            return BadRequest(new { Message = ex.Message });
        }
        catch (Exception ex)
        {
            return BadRequest(new {ErrorMessage = ex.Message});
        }
    
        return Ok(result);
    }
    
    [HttpPost()]
    public async Task<IActionResult> Add(Link link)
    {
        await _linkService.Add(link);
        return Ok();
    }
}