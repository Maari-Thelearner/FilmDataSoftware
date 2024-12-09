using System.ComponentModel.DataAnnotations;

namespace FilmDataAPI.Models;

public class Film
{
    [Key]
    public int FilmId { get; set; }
    
    [StringLength(100)]
    public string Title { get; set; }
    
    [StringLength(50)]
    public string Genre { get; set; }
    
    [RegularExpression(@"^(\d{4})$", ErrorMessage = "Enter a valid 4 digit Year")]
    public int? ReleaseYear { get; set; }
    
    public int DirectorId { get; set; } //foreignKey
    
    public Director Director { get; set; }
}