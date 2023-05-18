using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterManager: MonoBehaviour
{
    public static CounterManager Instance { get; private set; }

    private int counter = 0;
    private CounterUI counterUI;

    private void Awake()
    {
        if (Instance = null)
            Instance = this;
        else
            Destroy(gameObject);

        counterUI = FindObjectOfType<CounterUI>();
    }

    public void IncreaseCounter()
    {
        counter++;
        counterUI.UpdateCounter(counter);
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
