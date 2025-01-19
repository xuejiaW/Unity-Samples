using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineSample : MonoBehaviour
{
    private void Start() { StartCoroutine(WaitForTimeSample()); }

    private IEnumerator WaitForTimeSample()
    {
        Debug.Log("Enter WaitForTimeSample");
        yield return new WaitForTime(TimeSpan.FromSeconds(5));
        Debug.Log("Exit WaitForTimeSample");
    }
}