using System;
using System.Collections.Generic;
using UnityEngine;

public class BoneCollection : MonoBehaviour
{

}

[Serializable]
public class BoneCollectionData
{
    public List<Bone> bones = new List<Bone>();
}
