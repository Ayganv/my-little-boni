using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneUI : MonoBehaviour
{
    public GameObject boneCard;

    private void Start()
    {
        SaveSystem.LoadGame();
        CreateUIElements();
    }

    public void CreateUIElements()
    {
        foreach (var bone in BoneCollection.boneData.bones)
        {
            var clone = Instantiate(boneCard, this.transform);
            clone.GetComponent<BoneCard>().bone = bone;
        }
    }
}
