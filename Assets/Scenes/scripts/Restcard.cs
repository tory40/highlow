using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Restcard : MonoBehaviour
{

    //�c��J�[�h�̒l
    //UI�̍X�V

    [SerializeField] Text text;

    int value = 35;

    public void Setup()
    {
        value = 35;
        text.text = value.ToString();
    }

    public void CountDown(int take)
    {
        value -= take;
        text.text = value.ToString();
    }
}
