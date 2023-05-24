using UnityEngine;

public class DespawnTrigger : MonoBehaviour
{
    public string burgerTag = "burger";
    public string specificPlaceTag = "SpecificPlace";
    public SpawnManager spawnManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(burgerTag) && gameObject.CompareTag(specificPlaceTag))
        {
            spawnManager.DespawnPrefab();
        }
    }
}

