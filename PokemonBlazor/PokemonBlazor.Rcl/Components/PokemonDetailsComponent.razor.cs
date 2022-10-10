namespace PokemonBlazor.Rcl.Components;

public partial class PokemonDetailsComponent
{
    [Parameter, EditorRequired] public Pokemon Pokemon { get; set; } = default!;

    private string CssClass => Pokemon.Types.Any() ? Pokemon.Types[0].Type.Name : string.Empty;
}
