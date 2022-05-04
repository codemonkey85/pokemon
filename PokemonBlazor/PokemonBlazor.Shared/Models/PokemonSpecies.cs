namespace PokemonBlazor.Shared.Models;

public record PokemonSpecies(string Name, string Url)
{
    public PokemonSpeciesDetails? Details { get; set; }
}
