namespace PokemonBlazor.Rcl.Pages;

public partial class Index
{
    private IEnumerable<PokemonDto>? PokemonDtoList = null;

    protected override async Task OnInitializedAsync() => PokemonDtoList = await PokemonDtoService.GetPokemonDtoListAsync();
}
