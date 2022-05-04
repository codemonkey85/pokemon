namespace PokemonBlazor.Rcl.Components;

public partial class PokemonDetailsComponent
{
    [Parameter, EditorRequired] public Pokemon Pokemon { get; set; } = default!;

    private readonly IDictionary<string, object> Attributes = new Dictionary<string, object>();

    protected override async Task OnParametersSetAsync()
    {
        if (Pokemon?.Types?.Any() == true)
        {
            Attributes.Add("style", $"background-color: {GetColorForType(Pokemon.Types[0].Type)};");
        }

        //if (Pokemon.Details is null)
        //{
        //    Pokemon.Details = await PokeApiService.Get<PokemonDetails>(Pokemon.Url);
        //}
        //if (Pokemon.Details.Species.Details is null)
        //{
        //    Pokemon.Details.Species.Details = await PokeApiService.Get<PokemonSpeciesDetails>(Pokemon.Details.Species.Url);
        //}
    }
}
