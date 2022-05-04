namespace PokemonBlazor.Rcl.Pages;

public partial class PokemonDetailsPage
{
    [Parameter] public int Id { get; set; }

    private Pokemon? Pokemon { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        var pokemonDetailsUrl = $"https://pokeapi.co/api/v2/pokemon/{Id}/";
        Pokemon = await PokeApiService.Get<Pokemon>(pokemonDetailsUrl) with { Url = pokemonDetailsUrl };
    }
}
