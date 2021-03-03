using System;
using System.Collections.Generic;
using UnityEngine;

public static class BoneCollection
{
    public static BoneCollectionData boneData = new BoneCollectionData();
}

[Serializable]
public class BoneCollectionData
{
    public List<Bone> bones = new List<Bone>();

    public void AddBone(Rarity rarity, Type type)
    {
        Bone newBone = new Bone(rarity, type);
        bones.Add(newBone);
    }
}
