using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject[] Spawnpoints;
    public GameObject zombie;
    private void Start()
    {
        Spawnpoints = new GameObject[4];
        for (int i = 0; i < Spawnpoints.Length; i++)
        {
            Spawnpoints[i] = transform.GetChild(i).gameObject;
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
            SpawnEnemy();
    }

    private void SpawnEnemy()
    {
        int spawnerID = Random.Range(0, Spawnpoints.Length);
        Instantiate(zombie, Spawnpoints[spawnerID].transform.position, 
                            Spawnpoints[spawnerID].transform.rotation);
    }
}