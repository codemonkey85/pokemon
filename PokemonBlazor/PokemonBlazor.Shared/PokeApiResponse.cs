namespace PokemonBlazor.Shared;

public record PokeApiResponse<T>(int Count, string? Next, string? Previous, IEnumerable<T> Results);
