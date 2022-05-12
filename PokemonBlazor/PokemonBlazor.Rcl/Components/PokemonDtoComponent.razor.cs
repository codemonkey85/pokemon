namespace PokemonBlazor.Rcl.Components;

public partial class PokemonDtoComponent
{
    [Parameter, EditorRequired] public PokemonDto PokemonDto { get; set; } = default!;

    private string CssClass => string.Empty;
}
