using FilmDataAPI.Models;
using FilmDataAPI.Models.DTO;

namespace FilmDataAPI.Services;

public interface IDirectorService
{
    Task<Director> AddDirectorService(AddDirectorDTO dto);
}