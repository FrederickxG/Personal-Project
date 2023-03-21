using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour
{
  public GameObject[] WallPrefabs;

   private float spawnPosY = -1;
   private float spawnLimitLeft = -22;
   private float spawnLimitRight = -7;
   private float startDelay = 1.0f;
   private float spawnInterval = 3.0f;


   void Start()
    {
        InvokeRepeating("SpawnRandomWall", startDelay, spawnInterval);

    }

    // Spawn random Wall at random x position at top of play area
    void SpawnRandomWall()
    {
        // Generate random Wall index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitLeft, spawnLimitRight), spawnPosY, 0);

        int WallIndex = Random.Range(0, WallPrefabs.Length);

        // instantiate Wall at random spawn location
        Instantiate(WallPrefabs[WallIndex], spawnPos, WallPrefabs[WallIndex].transform.rotation);
    }
}
