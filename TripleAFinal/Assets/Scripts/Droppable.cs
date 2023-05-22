using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droppable : MonoBehaviour
{
    private bool isDropped = false;
    private CounterManager counterManager;
    public CounterUI counterUI;

    // Start is called before the first frame update
    void Start()
    {
        counterManager.GetComponent<CounterManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("SpecificPlace") && !isDropped)
        {
            isDropped = true;
            gameObject.SetActive(false);
            // Increase the counter
            CounterManager.IncreaseCounter();
            // Make the droppable object disappear
        }
    }

    
}
