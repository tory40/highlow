using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count2 : MonoBehaviour
{
    [SerializeField] Text number;
    public static int Countnum = 9;
    private void Start()
    {
        number.text = Countnum.ToString();
    }

    public void CountUp()
    {
        SoundManager.Instance.PlaySE(1);
        Countnum++;
        if (Countnum > 15)
        {
            Countnum = 1;
        }
        number.text = Countnum.ToString();
    }

    public void CountDown()
    {
        SoundManager.Instance.PlaySE(1);
        Countnum--;
        if (Countnum < 1)
        {
            Countnum = 15;
        }
        number.text = Countnum.ToString();
    }
}
