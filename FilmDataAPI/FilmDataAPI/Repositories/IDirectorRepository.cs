using FilmDataAPI.Models;

namespace FilmDataAPI.Repositories;

public interface IDirectorRepository
{
    Task<Director> AddAsync(Director entity);
}