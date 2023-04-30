using System.ComponentModel.DataAnnotations;

namespace GameCatalog.Models;

public class Game
{
    public int Id { get; set; }

    [Required]
    [StringLength(30)]
    public required string GameName { get; set; }
   
    [Required]
    [StringLength(30)]
    public required string Genre  { get; set; }

    [Range(1, 100)]
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }
}

