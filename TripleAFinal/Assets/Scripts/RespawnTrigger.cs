using UnityEngine;

public class RespawnTrigger : MonoBehaviour
{
    public string specificPlaceTag = "SpecificPlace";
    public SpawnManager spawnManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(specificPlaceTag) && !spawnManager.IsPrefabSpawned())
        {
            spawnManager.SpawnPrefab();
        }
    }
}


