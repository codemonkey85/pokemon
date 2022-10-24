namespace PokemonBlazor.Shared.Services;

public record PokemonDtoService(HttpClient HttpClient)
{
    private const string ApiUrl = @"https://pokeapi.co/api/v2/pokemon/";

    private IEnumerable<PokemonDto>? _pokemonDtoList;

    public async Task<IEnumerable<PokemonDto>> GetPokemonDtoListAsync()
    {
        if (_pokemonDtoList is null)
        {
            await GetAllPokemonDtosAsync();
        }

        return _pokemonDtoList!;
    }

    private async Task GetAllPokemonDtosAsync()
    {
        var apiResponseDto = await GetPokemonDtosAsync();
        if (apiResponseDto is not null)
        {
            _pokemonDtoList = apiResponseDto.Results;
        }
    }

    public async Task<ApiResponseDto?> GetPokemonDtosAsync(int offset = 0, int limit = 898) =>
        await HttpClient.GetFromJsonAsync<ApiResponseDto>($"{ApiUrl}?offset={offset}&limit={limit}");

    public async Task<PokemonDto?> GetPokemonDtoAsync(int id) =>
        await HttpClient.GetFromJsonAsync<PokemonDto>($"{ApiUrl}{id}");
}
