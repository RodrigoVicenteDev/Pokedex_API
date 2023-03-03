using Microsoft.EntityFrameworkCore;
using Pokedex.Models;

namespace Pokedex.Data
{
    public class PokemonContext : DbContext

    {
        public PokemonContext(DbContextOptions<PokemonContext> opts)
            : base(opts) 
        {

        }

        public DbSet<Pokemon> Pokemons { get; set; }
    }
}
