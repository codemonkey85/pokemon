namespace PokemonBlazor.Rcl.Pages;

public partial class GenVIIUnobtainablePage
{
    private readonly List<Pokemon> PokemonList = new();

    private readonly IList<int> UnobtainableIds = new[]
    {
            495,
            496,
            497,
            498,
            499,
            500,
            503,
            504,
            505,
            511,
            512,
            513,
            514,
            515,
            516,
            522,
            523,
            540,
            541,
            542,
            580,
            581,
            585,
            586,
            594,
            602,
            603,
            604,
            648,
            650,
            651,
            652,
            653,
            654,
            655,
            656,
            657,
            658,
            664,
            665,
            666,
            667,
            668,
            669,
            670,
            671,
            672,
            673,
            676,
            720,
            731,
            732,
            733,
            734,
            735,
            739,
            740,
            741,
            774,
            775,
            779,
        };

    protected override async Task OnInitializedAsync()
    {
        foreach (var unobtainableId in UnobtainableIds)
        {
            try
            {
                var pokemon = await PokeApiClient.GetResourceAsync<Pokemon>(unobtainableId);
                if (pokemon is not null)
                {
                    PokemonList.Add(pokemon);
                    StateHasChanged();
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error loading {unobtainableId}: {ex.Message}");
            }
        }
    }
}
