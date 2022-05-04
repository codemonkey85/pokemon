namespace PokemonBlazor.Rcl.Pages;

public partial class Index
{
    private IEnumerable<Pokemon> PokemonList = Array.Empty<Pokemon>();

    protected override async Task OnInitializedAsync()
    {
        var response = await PokeApiService.GetListOfPokemonAsync(limit: 10);
        PokemonList = response?.Results ?? Array.Empty<Pokemon>();
    }
}
