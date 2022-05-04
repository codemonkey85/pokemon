namespace PokemonBlazor.Shared.Models;

public class PokemonDetails
{
    public int Id { get; set; }

    public string Name { get; set; } = default!;

    public object Abilities { get; set; } = default!;

    public object Stats { get; set; } = default!;

    public object Moves { get; set; } = default!;

    public PokemonSpecies Species { get; set; } = default!;

    public string PaddedId => $"{Id:D3}";

    public string ImageUrl => $"https://assets.pokemon.com/assets/cms2/img/pokedex/detail/{PaddedId}.png";
}
