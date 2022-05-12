namespace PokemonBlazor.Rcl.Pages;

public partial class Index
{
    private readonly List<Pokemon> PokemonList = new();
    private int Loaded = 0;
    private const int Max = 898;

    protected override async Task OnInitializedAsync()
    {
        for (var id = 1; id <= Max; id++)
        {
            PokemonList.Add(await PokeApiClient.GetResourceAsync<Pokemon>(id));
            Loaded++;
            if (id == 5 || id % 20 == 0)
            {
                StateHasChanged();
            }
        }
    }
}
