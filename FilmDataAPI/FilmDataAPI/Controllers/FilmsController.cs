using FilmDataAPI.Models.DTO;
using FilmDataAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FilmDataAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class FilmsController: ControllerBase
{
    private readonly IFilmService _service;

    public FilmsController(IFilmService service)
    {
        this._service = service;
    }


    [HttpPost]
    public async Task<ActionResult> Addfilm([FromBody] AddFilmDTO dto, [FromQuery] Guid directorId)
    {
        try
        {
            var data = await this._service.AddNewFilmService(dto, directorId);
            return Ok(data);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
}