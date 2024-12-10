using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace FilmDataAPI.Models;

public class Director
{
    [Key]
    public Guid DirectorId { get; set; }
    
    [StringLength(100)]
    public string Name { get; set; }
    
    [StringLength(50)]
    public string Country { get; set; }
    
    public ICollection<Film> Films { get; set; }
}