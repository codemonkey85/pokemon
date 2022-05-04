namespace PokemonBlazor.Rcl.Components;

public partial class PokemonDetailsComponent
{
    [Parameter, EditorRequired] public Pokemon Pokemon { get; set; } = default!;

    protected override async Task OnParametersSetAsync()
    {
        if (Pokemon.Details is null)
        {
            Pokemon.Details = await PokeApiService.Get<PokemonDetails>(Pokemon.Url);
        }
        if (Pokemon.Details.Species.Details is null)
        {
            Pokemon.Details.Species.Details = await PokeApiService.Get<PokemonSpeciesDetails>(Pokemon.Details.Species.Url);
        }
    }
}
