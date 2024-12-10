using FilmDataAPI.Data;
using FilmDataAPI.Models;
using Microsoft.EntityFrameworkCore;

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

    public async Task<List<Film>> GetAllFilmsAsync()
    {
        List<Film> films = await this._context.Films.ToListAsync();

        return films;
    }

    public async Task<Film> GetFilmByIdAsync(Guid id)
    {
        return await this._context.Films.Where(x => x.FilmId == id).FirstOrDefaultAsync();
    }
}