using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text counterText;

    private int count = 0;

    private void Start()
    {
        count = 0;
    }

    public void AddCount(int addCount)
    {
        count += addCount;
        counterText.text = "Count : " + count;
    }
}
