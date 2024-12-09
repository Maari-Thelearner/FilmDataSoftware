using System.ComponentModel.DataAnnotations;

namespace FilmDataAPI.Models;

public class Director
{
    [Key]
    public int DirectorId { get; set; }
    
    [StringLength(100)]
    public string Name { get; set; }
    
    [StringLength(50)]
    public string Country { get; set; }
    
    public ICollection<Film> Films { get; set; }
}