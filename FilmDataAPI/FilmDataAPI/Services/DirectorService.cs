using FilmDataAPI.Models;
using FilmDataAPI.Models.DTO;
using FilmDataAPI.Repositories;

namespace FilmDataAPI.Services;

public class DirectorService : IDirectorService
{
    private readonly IDirectorRepository _directorRepository;

    public DirectorService(IDirectorRepository directorRepository)
    {
        this._directorRepository = directorRepository;
    }

    public async Task<Director> AddDirectorService(AddDirectorDTO dto)
    {
        Director director = new Director()
        {
            DirectorId = new Guid(),
            Country = dto.Country,
            Name = dto.Name
        };

        await this._directorRepository.AddAsync(director);

        return director;
    }
}