using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterUI : MonoBehaviour
{
    private Text counterText;
    private int counter = 0;

    // Start is called before the first frame update
    private void Awake()
    {
        counterText = GetComponent<Text>();
    }

    private void Start()
    {
        UpdateCounterText();
    }

    public void UpdateCounter(int newCounter)
    {
        counter = newCounter;
        UpdateCounterText();
    }

    public void UpdateCounterText()
    {
        counterText.text = "Money Earned: " + counter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
