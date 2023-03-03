using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Data;
using Pokedex.Data.Dtos;
using Pokedex.Models;

namespace Pokedex.Controllers;

[ApiController]
[Route("[controller]")]
public class PokemonController : ControllerBase
{
    private PokemonContext _context;
    private IMapper _mapper;

    public PokemonController(PokemonContext context, IMapper mapper = null)
    {
        _context = context;
        _mapper = mapper;
    }


    [HttpPost]
    public void AdicionarPokemon([FromBody] CreatePokemonDTO pokemonDto)
    {
        Pokemon pokemon = _mapper.Map<Pokemon>(pokemonDto);
        _context.Pokemons.Add(pokemon);
        _context.SaveChanges();
        

    }

    [HttpGet]
    public List<Pokemon> RecuperarPokemon()
    {
        return _context.Pokemons.ToList();


    }

    [HttpGet("{id}")]

    public IActionResult RecuperaFilmePorId(int id)
    {
        var pokemon = _context.Pokemons.FirstOrDefault(pokemon => pokemon.Id == id);
        if (pokemon == null) return NotFound();
        return Ok(pokemon);
    }


    [HttpPut("{id}")]

    public IActionResult AtualizaPokemon(int id, [FromBody] UpdatePokemonDTO pokemonDto )
    {
        var pokemon = _context.Pokemons.FirstOrDefault(pokemon => pokemon.Id == id);
        if (pokemon == null) return NotFound();
        _mapper.Map(pokemonDto, pokemon);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletarFilme(int id)
    {
        var pokemon = _context.Pokemons.FirstOrDefault(pokemon => pokemon.Id == id);
        if (pokemon == null) return NotFound();
        _context.Remove(pokemon);
        _context.SaveChanges();
        return NoContent();

    }

}
