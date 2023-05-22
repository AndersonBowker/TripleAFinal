using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject prefabToRespawn;
    public float respawnTime = 20f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RespawnCoroutine());
    }

    IEnumerator RespawnCoroutine()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnPrefab();
        }
    }

    void SpawnPrefab()
    {
        GameObject spawnedObject = Instantiate(prefabToRespawn);
        spawnedObject.transform.position = transform.position;
        spawnedObject.transform.rotation = transform.rotation;
        spawnedObject.transform.SetParent(transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
