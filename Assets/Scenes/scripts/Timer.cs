using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public void Time(int i) 
    {
        StartCoroutine(CountDown(i));
    }
    IEnumerator CountDown(int i) 
    {
        yield return new WaitForSeconds(i);
    }
}