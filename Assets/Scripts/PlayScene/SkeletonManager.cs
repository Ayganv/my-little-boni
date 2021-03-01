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

        if (Input.touchCount > 0)
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.GetTouch(0).position), out RaycastHit hit))
            {
                var walkerScript = hit.collider.gameObject.GetComponent<WalkerScript>();
                if (walkerScript != null)
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit, float.MaxValue))
            {
                Debug.Log(hit.collider.gameObject.name);
                var walkerScript = hit.collider.gameObject.GetComponent<WalkerScript>();
                if (walkerScript != null)
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(Camera.main.ScreenPointToRay(Input.mousePosition).origin, Camera.main.ScreenPointToRay(Input.mousePosition).origin + Camera.main.ScreenPointToRay(Input.mousePosition).direction);
    }
}
