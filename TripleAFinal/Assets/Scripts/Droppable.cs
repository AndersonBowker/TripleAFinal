using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droppable : MonoBehaviour
{
    private bool isDropped = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("SpecificPlace") && !isDropped)
        {
            isDropped = true;
            // Increase the counter
            CounterManager.Instance.IncreaseCounter();
            // Make the droppable object disappear
            gameObject.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
