using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spowner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float minTime = 1.5f;
    public float maxTime = 4f;
    [UnitHeaderInspectable("Group Settings")]
    public int minCount = 1;
    public int maxCount = 4;
    public float spacing = 1.5f;
    void Start()
    {
        SpawnObject();
    }
    void SpawnObject()
    {
        int countToSpawn = Random.Range(minCount, maxCount + 1);
        for(int i = 0; i < countToSpawn; i++)
        {
            Vector3 spawnPos = transform.position + new Vector3(i * spacing,0, 0);
            Instantiate(coinPrefab, spawnPos, Quaternion.identity);
        }
       float nextSpawnTime = Random.Range(minTime, maxTime);
         Invoke("SpawnObject", nextSpawnTime);  
    }

}