using System;
using System.Collections;
using UnityEngine;

public class WaitForTime : IEnumerator
{
    private readonly DateTime m_EndTime;
    public WaitForTime(TimeSpan time) { m_EndTime = DateTime.Now + time; }

    public bool MoveNext()
    {
        Debug.Log("Called MoveNext");
        return DateTime.Now < m_EndTime;
    }

    public void Reset() { }

    public object Current
    {
        get
        {
            Debug.Log("Called Current");
            return null;
        }
    }
}