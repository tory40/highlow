using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Type2 : MonoBehaviour
{
    [SerializeField] Text number;
    public static int Typenum = 4;
    private void Start()
    {
        number.text = Typenum.ToString();
    }

    public void CountUp()
    {
        SoundManager.Instance.PlaySE(1);
        Typenum++;
        if (Typenum > 4)
        {
            Typenum = 1;
        }
        number.text = Typenum.ToString();
    }

    public void CountDown()
    {
        SoundManager.Instance.PlaySE(1);
        Typenum--;
        if (Typenum < 1)
        {
            Typenum = 4;
        }
        number.text = Typenum.ToString();
    }
}
