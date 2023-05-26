using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabsToSpawn;
    public Transform spawnLocation;
    public float spawnTimer = 2f;

    private GameObject currentSpawnedPrefab;
    private bool isSpawned = false;

    private void Start()
    {
        // Start the timer for the initial spawn
        Invoke("SpawnPrefab", spawnTimer);
    }

    public void SpawnPrefab()
    {
        // Randomly select a prefab from the array
        int randomIndex = Random.Range(0, prefabsToSpawn.Length);
        GameObject prefab = prefabsToSpawn[randomIndex];

        // Instantiate the prefab at the spawn location
        currentSpawnedPrefab = Instantiate(prefab, spawnLocation.position, Quaternion.identity);

        // Start the timer for the next spawn
        Invoke("SpawnPrefab", spawnTimer);
        isSpawned = true;
    }

    public void DespawnPrefab()
    {
        if (currentSpawnedPrefab != null)
        {
            Destroy(currentSpawnedPrefab);
            isSpawned = false;
        }
    }
    
    public bool IsPrefabSpawned()
    {
        return isSpawned;
    }
}

