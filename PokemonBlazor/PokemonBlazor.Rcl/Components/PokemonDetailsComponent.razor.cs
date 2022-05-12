namespace PokemonBlazor.Rcl.Components;

public partial class PokemonDetailsComponent
{
    [Parameter, EditorRequired] public PokemonDto PokemonDto { get; set; } = default!;

    public Pokemon? Pokemon { get; set; }

    private string CssClass => Pokemon?.Types?.Any() == true ? Pokemon.Types[0].Type.Name : string.Empty;

    protected override async Task OnParametersSetAsync()
    {
        if (PokemonDto is not null)
        {
            Pokemon = await PokeApiClient.GetResourceAsync<Pokemon>(PokemonDto.Id);
        }
    }
}
