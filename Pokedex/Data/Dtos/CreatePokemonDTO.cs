using System.ComponentModel.DataAnnotations;

namespace Pokedex.Data.Dtos;

public class CreatePokemonDTO
{
   
    [Required]
    public string Nome { get; set; }
    [Required]
    public string Tipo { get; set; }

    public int Numero { get; set; }
    public string Foto { get; set; }
}
