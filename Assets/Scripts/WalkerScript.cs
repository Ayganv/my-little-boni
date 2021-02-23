using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkerScript : MonoBehaviour
{
    void Update()
    {
        transform.position += transform.right * Time.deltaTime;
    }
}
