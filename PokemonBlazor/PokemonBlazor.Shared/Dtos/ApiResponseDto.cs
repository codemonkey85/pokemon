namespace PokemonBlazor.Shared.Dtos;

public record ApiResponseDto(int Count, string? Next, string? Previous, IEnumerable<PokemonDto> Results);
