using FilmDataAPI.Data;
using FilmDataAPI.Models;

namespace FilmDataAPI.Repositories;

public class DirectorRepository : IDirectorRepository
{
    private readonly ApplicationDBContext _context;

    public DirectorRepository(ApplicationDBContext context)
    {
        this._context = context;
    }

    public async Task<Director> AddAsync(Director entity)
    {
        await this._context.Directors.AddAsync(entity);
        await this._context.SaveChangesAsync();

        return entity;
    }
}