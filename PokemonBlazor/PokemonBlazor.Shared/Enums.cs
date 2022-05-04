namespace PokemonBlazor.Shared;

public static class Enums
{
    public enum PokemonTypes
    {
        Normal,
        Fighting,
        Flying,
        Poison,
        Ground,
        Rock,
        Bug,
        Ghost,
        Steel,
        Fire,
        Water,
        Grass,
        Electric,
        Psychic,
        Ice,
        Dragon,
        Dark,
        Fairy,
    };

    public static string GetColorForType(PokemonTypes type) => type switch
    {
        PokemonTypes.Fire => "#fd7d24",
        PokemonTypes.Grass => "#9bcc50",
        PokemonTypes.Electric => "#eed535",
        PokemonTypes.Water => "#4592c4",
        PokemonTypes.Ground => "#ab9842",
        PokemonTypes.Rock => "#a38c21",
        PokemonTypes.Fairy => "#fdb9e9",
        PokemonTypes.Poison => "#b97fc9",
        PokemonTypes.Bug => "#729f3f",
        PokemonTypes.Dragon => "#97b3e6",
        PokemonTypes.Psychic => "#f366b9",
        PokemonTypes.Flying => "#3dc7ef",
        PokemonTypes.Fighting => "#d56723",
        PokemonTypes.Normal => "#a4acaf",
        PokemonTypes.Ghost => "#7b62a3",
        PokemonTypes.Steel => "#9eb7b8",
        PokemonTypes.Dark => "#707070",
        PokemonTypes.Ice => "#51c4e7",
        _ => string.Empty,
    };
}
