using FilmDataAPI.Models.DTO;
using FilmDataAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FilmDataAPI.Controllers;


[ApiController]
[Route("api/[controller]/[action]")]
public class DirectorsController: ControllerBase
{
    private readonly IDirectorService _directorService;

    public DirectorsController(IDirectorService directorService)
    {
        this._directorService = directorService;
    }


    [HttpPost]
    public async Task<IActionResult> AddDirectors([FromBody]AddDirectorDTO dto)
    {
        try
        {
           var data =  await this._directorService.AddDirectorService(dto);
           return Ok(data);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
}