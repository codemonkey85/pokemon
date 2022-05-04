namespace PokemonBlazor.Rcl.Components;

public partial class PokemonComponent
{
    [Parameter, EditorRequired] public Pokemon Pokemon { get; set; } = default!;

    protected override async Task OnParametersSetAsync()
    {
        if (Pokemon.Details is null)
        {
            Pokemon.Details = await PokeApiService.Get<PokemonDetails>(Pokemon.Url);
        }
    }
}
