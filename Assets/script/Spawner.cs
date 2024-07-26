using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    public TextMeshProUGUI texttimeout;
    public Transform[] spawnPoints;
    public GameObject enemy;
    public float startTimeBtwSpawns;
    float timeBtwSpawns;

    public int maxEnemies = 10;
    private int currentEnemies = 0;
    private int spawnIncrement = 3;

    private bool initialSpawnComplete = false;
    public float initialWaitTime = 10f;  // ?ã thay ??i thành 10 giây
    

    private void Start()
    {
        // Kh?i t?o th?i gian ch?
        timeBtwSpawns = startTimeBtwSpawns;
    }

    private void Update()
    {
        if (!initialSpawnComplete)
        {
            initialWaitTime -= Time.deltaTime;
            texttimeout.text = "" + Mathf.Round(initialWaitTime);
            if (initialWaitTime <= 0.0f)
            {
                initialSpawnComplete = true;
                // Spawn 3 quái ??u tiên sau khi ch? 10 giây
                for (int i = 0; i < spawnIncrement; i++)
                {
                    SpawnEnemy();
                }
                spawnIncrement = 5;
                startTimeBtwSpawns = Mathf.Max(startTimeBtwSpawns * 0.9f, 0.5f);
                timeBtwSpawns = startTimeBtwSpawns; // ??t l?i th?i gian ch? gi?a các l?n spawn
            }
            return;
        }

        if (currentEnemies < maxEnemies)
        {
            if (timeBtwSpawns <= 0)
            {
                SpawnEnemy();
                startTimeBtwSpawns = Mathf.Max(startTimeBtwSpawns * 0.9f, 0.5f);
                timeBtwSpawns = startTimeBtwSpawns;
            }
            else
            {
                timeBtwSpawns -= Time.deltaTime;
            }
        }
    }

    private void SpawnEnemy()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Vector3 spawnPosition = spawnPoints[randomIndex].position;
        Instantiate(enemy, spawnPosition, Quaternion.identity);
        currentEnemies++;
    }
}
