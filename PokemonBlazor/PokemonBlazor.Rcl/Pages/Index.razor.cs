namespace PokemonBlazor.Rcl.Pages;

public partial class Index
{
    private IEnumerable<PokemonDto>? _pokemonDtoList;

    protected override async Task OnInitializedAsync() =>
        _pokemonDtoList = await PokemonDtoService.GetPokemonDtoListAsync();
}
