using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Remain : MonoBehaviour
{
    [SerializeField] Text[] remains;


    public void SetUp() 
    {
        for (int i = 0; i < 9; i++)
        {
            remains[i].color = Color.yellow;
        }
        for (int i = 9; i < 9*2; i++)
        {
            remains[i].color = Color.red;
        }
        for (int i = 9*2; i < 9*3; i++)
        {
            remains[i].color = Color.green;
        }
        for (int i = 9*3; i < 9*4; i++)
        {
            remains[i].color = Color.blue;
        }
    }

    public void delete(int i) 
    {
        if (i <= 0) 
        {
            return;
        }
        Init(remains[i-1]);

    }

    public void Init(Text remain) 
    {
        remain.color = Color.gray;
    }
}
