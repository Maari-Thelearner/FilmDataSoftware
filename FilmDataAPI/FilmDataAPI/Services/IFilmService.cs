using FilmDataAPI.Models;
using FilmDataAPI.Models.DTO;

namespace FilmDataAPI.Services;

public interface IFilmService
{
    Task<Film> AddNewFilmService(AddFilmDTO dto, Guid directorId);

    Task<List<Film>> GetAllFilmsService();
}