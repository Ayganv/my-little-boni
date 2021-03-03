using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoneCard : MonoBehaviour
{
    public Bone bone;

    [Header("UI Tester")]
    public Image image;
    public Text text;

    private void Start()
    {
        switch (bone.type)
        {
            case Type.Skull:
                Debug.Log("Is Skull!");
                break;
            case Type.Arm:
                Debug.Log("Is Arm!");
                break;
            case Type.Leg:
                Debug.Log("Is Leg!");
                break;
            case Type.Body:
                Debug.Log("Is Body!");
                break;
            default:
                Debug.Log("Is Bone!");
                break;
        }

        text.text = bone.name;
    }
}
