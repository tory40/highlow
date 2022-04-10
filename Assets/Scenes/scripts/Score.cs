using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    //�X�R�A�̒l
    //UI�̍X�V

    [SerializeField] Text text;

    int value = 0;

    public void Setup() 
    {
        value = 0;
        text.text = value.ToString();
    }

    public void ScoreUp (int add)
    {
        value += add;
        text.text = value.ToString();
    }
}
