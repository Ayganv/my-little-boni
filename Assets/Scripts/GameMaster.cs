using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    static public GameMaster instance;

    [Header("Poggers Systems")]
    public SaveSystem saveSystem;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        saveSystem = GetComponent<SaveSystem>();
    }
}
