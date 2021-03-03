using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerData
{
    public static int PlayerExperience
    {
        get => PlayerPrefs.GetInt("PlayerExperience", 0);
        set
        {
            if (value > ExperienceRequired())
            {
                value -= ExperienceRequired();
                PlayerLevel++;
            }
            PlayerPrefs.SetInt("PlayerExperience", value);
        }
    }

    public static int PlayerLevel { get => PlayerPrefs.GetInt("PlayerLevel", 1); set => PlayerPrefs.SetInt("PlayerLevel", value); }

    const int baseExperienceRequired = 5;
    const int experienceIncreasePerLevel = 1;

    public static int ExperienceRequired()
    {
        return ((PlayerLevel - 1) * experienceIncreasePerLevel) + baseExperienceRequired;
    }

    public static int ExperienceUntilLevelUp()
    {
        return ExperienceRequired() - PlayerExperience;
    }

    public static int amountOfSkeletonsMade()
    {
        return 0;
    }
}
