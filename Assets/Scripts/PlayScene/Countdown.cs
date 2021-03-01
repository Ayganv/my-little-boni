using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float startTime;
    public float timeBeforeEnd;
    public Text text;

    private void Awake()
    {
        startTime = Time.time;
    }

    void Update()
    {
        text.text = $"CountDown: {timeBeforeEnd + Mathf.RoundToInt(startTime - Time.time)}";
        if (Time.time - startTime > timeBeforeEnd)
        {
            FindObjectOfType<SceneLoader>().LoadScene("InitialScreen");
        }
    }
}
