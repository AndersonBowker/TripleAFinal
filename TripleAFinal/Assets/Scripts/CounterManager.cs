using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterManager: MonoBehaviour
{
    public static int counter = 0;
    public static CounterUI counterUI;

    private void Awake()
    {
        counterUI = FindObjectOfType<CounterUI>();
    }

    public static void IncreaseCounter()
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
