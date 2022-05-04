namespace PokemonBlazor.Rcl.Services;

public record PokeApiService(HttpClient HttpClient)
{
    public async Task<T> Get<T>(string url) =>
        await HttpClient.GetFromJsonAsync<T>(url) ?? default!;

    public async Task<PokeApiResponse<T>> GetWrappedResult<T>(string url) =>
        await HttpClient.GetFromJsonAsync<PokeApiResponse<T>>(url) ?? default!;

    public async Task<PokeApiResponse<Pokemon>> GetListOfPokemonAsync(int offset = 0, int limit = 898) =>
        await GetWrappedResult<Pokemon>($"https://pokeapi.co/api/v2/pokemon?offset={offset}&limit={limit}") ?? default!;
}
