using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneTesting : MonoBehaviour
{
    public void AddRandomBone()
    {
        BoneCollection.boneData.AddBone(GetRandomRarity(), GetRandomType());
        SaveSystem.SaveGame();
    }

    private Type GetRandomType()
    {
        int num = Random.Range(0, 3);

        switch (num)
        {
            case 0:
                return Type.Skull;
            case 1:
                return Type.Leg;
            case 2:
                return Type.Arm;
            case 3:
                return Type.Body;
            default:
                return Type.Skull;
        }
    }

    private Rarity GetRandomRarity()
    {
        int num = Random.Range(0, 4);

        switch(num)
        {
            case 0:
                return Rarity.Common;
            case 1:
                return Rarity.Uncommon;
            case 2:
                return Rarity.Rare;
            case 3:
                return Rarity.Epic;
            case 4:
                return Rarity.Legendary;
            default:
                return Rarity.Common;
        }
    }
}
