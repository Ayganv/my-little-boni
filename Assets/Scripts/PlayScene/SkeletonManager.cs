using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SkeletonManager : MonoBehaviour
{
    public float minHeight = -4;
    public float maxHeight = 2.5f;
    public float distanceFromCenter = 15;
    public GameObject skeletonPrefab;

    public float timeBetweenSpawn = 1;
    public float lastSpawnTime;
    
    public void SpawnSkeleton()
    {
        var newSkeleton = Instantiate(skeletonPrefab);
        var heading = Random.Range(0, 2);
        var height = Random.Range(minHeight, maxHeight);
        if (heading == 0)
        {
            newSkeleton.transform.position = new Vector3(-distanceFromCenter, height, height);
        }
        else
        {
            newSkeleton.transform.Rotate(0,180,0);
            newSkeleton.transform.position = new Vector3(distanceFromCenter, height, height);
        }

        lastSpawnTime = Time.time;
    }

    private void Update()
    {
        if (Time.time - lastSpawnTime > timeBetweenSpawn)
        {
            SpawnSkeleton();
        }
    }
}
