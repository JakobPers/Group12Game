using UnityEngine;

public class Spawner : MonoBehaviour
{
    private int waveNumber = 0;
    private int zombieSpawnAmount = 0;
    public static int zombiesKilled = 0;

    public GameObject[] Spawnpoints;
    public GameObject zombie;
    public GameObject desbien;

    private void Start()
    {
        Spawnpoints = new GameObject[4];
        for (int i = 0; i < Spawnpoints.Length; i++)
        {
            Spawnpoints[i] = transform.GetChild(i).gameObject;
        }

        StartWave();
    }

    private void Update()
    {
        if (zombiesKilled >= zombieSpawnAmount)
        {
            NextWave();
        }
    }

    private void SpawnEnemy()
    {
        int spawnerID = Random.Range(0, Spawnpoints.Length);
        Instantiate(zombie, Spawnpoints[spawnerID].transform.position, Spawnpoints[spawnerID].transform.rotation);
        Instantiate(desbien, Spawnpoints[spawnerID].transform.position, Spawnpoints[spawnerID].transform.rotation);
    }

    private void StartWave()
    {
        waveNumber = 1;
        zombieSpawnAmount = 1;
        zombiesKilled = 0;
        for (int i = 0; i < zombieSpawnAmount; i++)
        {
            SpawnEnemy();
        }
    }

    public void NextWave()
    {
        waveNumber++;
        zombieSpawnAmount += 1;
        zombiesKilled = 0;
        for (int i = 0; i < zombieSpawnAmount; i++)
        {
            SpawnEnemy();
        }
    }
}