using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    [SerializeField] Text Musicnum;
    int bgmvalue = 0;
    int BGMnum;
    private void Start()
    {
        BGMnum = bgmvalue + 1;
        Musicnum.text = BGMnum.ToString();
    }

    public void CountUp() 
    {
        SoundManager.Instance.PlaySE(1);
        bgmvalue++;
        if (bgmvalue > 2) 
        {
            bgmvalue = 0;
        }
        Init();
    }

    public void CountDown() 
    {
        SoundManager.Instance.PlaySE(1);
        bgmvalue--;
        if (bgmvalue < 0) 
        {
            bgmvalue = 2;
        }
        Init();
    }
    public void Init()
    {
        SoundManager.Instance.PlayBGM(bgmvalue);
        int BGMnum = bgmvalue + 1;
        Musicnum.text = BGMnum.ToString();
    }
}
