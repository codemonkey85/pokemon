namespace PokemonBlazor.Shared.Models;

public record Pokemon(string Name, string Url)
{
    public PokemonDetails? Details { get; set; }
}
