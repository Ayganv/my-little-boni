using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkerScript : MonoBehaviour
{
    private void Awake()
    {
        Destroy(gameObject, 30f);
    }

    void Update()
    {
        transform.position += transform.right * Time.deltaTime;
    }
}
