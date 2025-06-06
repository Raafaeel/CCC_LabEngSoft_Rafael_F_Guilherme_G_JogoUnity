using UnityEngine;
using Battle;
using Core;

public static class DifficultyConfig
{
    public static Difficulty currentDifficulty { get; set; } = Difficulty.Medium;

    public static float GetMultiplierHP()
    {
        switch (currentDifficulty)
        {
            case Difficulty.Medium: return 1.0f;
            case Difficulty.Hard: return 1.5f;
            default: return 1.0f;
        }
    }

    public static float GetMultiplierSTR()
    {
        switch (currentDifficulty)
        {
            case Difficulty.Medium: return 1.0f;
            case Difficulty.Hard: return 1.2f;
            default: return 1.0f;
        }
    }

    public static float GetMultiplierARM()
    {
        switch (currentDifficulty)
        {
            case Difficulty.Medium: return 1.0f;
            case Difficulty.Hard: return 1.2f;
            default: return 1.0f;
        }
    }
}
