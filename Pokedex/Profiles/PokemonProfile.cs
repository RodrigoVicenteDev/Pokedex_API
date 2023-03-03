using AutoMapper;
using Pokedex.Data.Dtos;
using Pokedex.Models;

namespace Pokedex.Profiles;

public class PokemonProfile : Profile
{
    public PokemonProfile() 
    {
        CreateMap<CreatePokemonDTO, Pokemon>();
        CreateMap<UpdatePokemonDTO, Pokemon>();

    } 
}
