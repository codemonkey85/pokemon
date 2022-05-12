namespace PokemonBlazor.Shared.Dtos;

public record PokemonDto
{
    public int Id
    {
        get
        {
            if (string.IsNullOrEmpty(Url))
            {
                return 0;
            }
            var idString = Url.Replace("https://pokeapi.co/api/v2/pokemon/", string.Empty)[..^1];
            return int.TryParse(idString, out var id) ? id : 0;
        }
    }

    public string Name { get; set; }

    public string Url { get; set; }

    public List<PokemonType> Types { get; set; }
}
