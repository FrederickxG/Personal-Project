using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] targetPrefabs;

    private float spawnLimitLeft = -22;
    private float spawnLimitRight = -7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomTarget", startDelay, spawnInterval);
    }

    // Spawn random target at random x position at top of play area
    void SpawnRandomTarget()
    {
        // Generate random target index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitLeft, spawnLimitRight), spawnPosY, 0);

        int targetIndex = Random.Range(0, targetPrefabs.Length);

        // instantiate target at random spawn location
        Instantiate(targetPrefabs[targetIndex], spawnPos, targetPrefabs[targetIndex].transform.rotation);
    }
}
