﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] GameObject obstacleObj;
    List<GameObject> obstaclesOnMap = new List<GameObject>();

    private IEnumerator coroutine;
    void Start()
    {
        SpawnObstacle(new Vector3(0f, 0.4f, 20f));
        for (int i = 0; i < 20; i++)
        {
            SpawnObstacle(obstaclesOnMap[obstaclesOnMap.Count - 1].transform.position);
        }

        coroutine = WaitToSpawn(1f);
        StartCoroutine(coroutine);
    }

    void Update()
    {
        
    }

   

    void SpawnObstacle(Vector3 lastObjPosition)
    {
        Vector3 spawnPosition = new Vector3(((int)Random.Range(-1.9f, 1.9f) * 3), lastObjPosition.y, lastObjPosition.z + 10);
        obstaclesOnMap.Add(Instantiate(obstacleObj, spawnPosition, Quaternion.Euler(0,0,0)));
      
    
    
    }   
    IEnumerator WaitToSpawn(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            SpawnObstacle(obstaclesOnMap[obstaclesOnMap.Count - 1].transform.position);
            if (obstaclesOnMap.Count > 50)
            {
                Destroy(obstaclesOnMap[0]);
                obstaclesOnMap.Remove(obstaclesOnMap[0]);
            }
        }
    }
}
