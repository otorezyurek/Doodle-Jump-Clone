using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] platforms;
    public int platformCount;
    public float levelWidth = 2.5f;
    public float minY;
    public float maxY;

    void Start()
    {
        Vector3 spawnPos = new Vector3();

        for (int i = 0; i < platformCount; i++)
		{
            spawnPos.y += Random.Range(minY, maxY);
            spawnPos.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platforms[Random.Range(0, platforms.Length)], spawnPos, Quaternion.identity);
		}


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
