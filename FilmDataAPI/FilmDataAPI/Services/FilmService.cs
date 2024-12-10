using System.Runtime.InteropServices.Marshalling;
using FilmDataAPI.Models;
using FilmDataAPI.Models.DTO;
using FilmDataAPI.Repositories;

namespace FilmDataAPI.Services;

public class FilmService : IFilmService
{
    private readonly IFilmRepository _filmRepository;

    public FilmService(IFilmRepository filmRepository)
    {
        this._filmRepository = filmRepository;
    }
    
    public async Task<Film> AddNewFilmService(AddFilmDTO dto, Guid directorId)
    {
        Film film = new Film()
        {
            FilmId = new Guid(),
            Title = dto.Title,
            Genre = dto.Genre,
            ReleaseYear = dto.ReleaseYear,
            DirectorId = directorId
        };
        await this._filmRepository.AddAsync(film);
        return film;
    }

    public async Task<List<Film>> GetAllFilmsService()
    {
        return await this._filmRepository.GetAllFilmsAsync();
    }
}