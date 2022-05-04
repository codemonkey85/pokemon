namespace PokemonBlazor.Shared;

public static class ArtworkHelper
{
    public static string GetArtworkUrl(int id) => $"https://assets.pokemon.com/assets/cms2/img/pokedex/detail/{id:D3}.png";
}
