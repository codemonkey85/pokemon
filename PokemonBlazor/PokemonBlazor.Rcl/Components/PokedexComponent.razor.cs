namespace PokemonBlazor.Rcl.Components;

public partial class PokedexComponent
{
    [Parameter, EditorRequired] public IEnumerable<Pokemon> PokemonList { get; set; } = Array.Empty<Pokemon>();
}
