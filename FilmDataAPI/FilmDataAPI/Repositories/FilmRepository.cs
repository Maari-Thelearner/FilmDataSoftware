using FilmDataAPI.Data;
using FilmDataAPI.Models;

namespace FilmDataAPI.Repositories;

public class FilmRepository : IFilmRepository
{
    private readonly ApplicationDBContext _context;

    public FilmRepository(ApplicationDBContext context)
    {
        this._context = context;
    }
    public async Task<Film> AddAsync(Film entity)
    {
        await this._context.Films.AddAsync(entity);
        await this._context.SaveChangesAsync();

        return entity;
    }
}