namespace PokemonBlazor.Rcl.Pages;

public partial class PokemonDetailsPage
{
    [Parameter] public int Id { get; set; }

    private Pokemon? Pokemon { get; set; }

    protected override async Task OnParametersSetAsync() => Pokemon = await PokeApiClient.GetResourceAsync<Pokemon>(Id);
}
