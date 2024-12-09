using FilmDataAPI.Models;

namespace FilmDataAPI.Repositories;

public interface IFilmRepository
{
    Task<Film> AddAsync(Film entity);
}