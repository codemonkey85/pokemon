namespace PokemonBlazor.Shared;

public static class StaticFunctions
{
    public static string GetColorForType(NamedApiResource<PokeApiNet.Type> type) => type switch
    {
        { Name: "fire" } => "#fd7d24",
        { Name: "grass" } => "#9bcc50",
        { Name: "electric" } => "#eed535",
        { Name: "water" } => "#4592c4",
        { Name: "ground" } => "#ab9842",
        { Name: "rock" } => "#a38c21",
        { Name: "fairy" } => "#fdb9e9",
        { Name: "poison" } => "#b97fc9",
        { Name: "bug" } => "#729f3f",
        { Name: "dragon" } => "#97b3e6",
        { Name: "psychic" } => "#f366b9",
        { Name: "flying" } => "#3dc7ef",
        { Name: "fighting" } => "#d56723",
        { Name: "normal" } => "#a4acaf",
        { Name: "ghost" } => "#7b62a3",
        { Name: "steel" } => "#9eb7b8",
        { Name: "dark" } => "#707070",
        { Name: "ice" } => "#51c4e7",
        _ => string.Empty,
    };

    public static string GetPokemonArtworkUrl(int id) => $"https://assets.pokemon.com/assets/cms2/img/pokedex/detail/{id:D3}.png";
}
