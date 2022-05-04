namespace PokemonBlazor.Rcl.Pages;

public partial class Index
{
    private IEnumerable<Pokemon> PokemonList = Array.Empty<Pokemon>();

    protected override async Task OnInitializedAsync() =>
        PokemonList = await PokeApiClient.GetResourceAsync((
            await PokeApiClient.GetNamedResourcePageAsync<Pokemon>(10, 0)).Results.Select(result => result));
}
