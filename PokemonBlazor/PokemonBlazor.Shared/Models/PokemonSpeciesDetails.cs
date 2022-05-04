namespace PokemonBlazor.Shared.Models;

public class PokemonSpeciesDetails
{
    [JsonPropertyName("evolution_chain")]
    public object? EvolutionChain { get; set; }
}
