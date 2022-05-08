using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Restcard : MonoBehaviour
{

    //残りカードの値
    //UIの更新

    [SerializeField] Text text;

    int value = (Count2.Countnum*Type2.Typenum)-1;

    public void Setup()
    {
        value = (Count2.Countnum * Type2.Typenum) - 1;
        text.text = value.ToString();
    }

    public void CountDown(int take)
    {
        value -= take;
        if (value < 0)
        {
            value = 0;
        }
        text.text = value.ToString();
       
    }    
           
}
