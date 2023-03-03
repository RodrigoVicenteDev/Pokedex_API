using System.ComponentModel.DataAnnotations;

namespace Pokedex.Models;

public class Pokemon
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public string Nome { get; set; }
    [Required]
    public string Tipo { get; set; }

    public int Numero { get; set; } 
    public string Foto { get; set; }

}
