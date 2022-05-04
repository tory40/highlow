using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    //スコアの値
    //UIの更新

    [SerializeField] Text text;

    public static int score = 0;

    public void Setup() 
    {
        score = 0;
        text.text = score.ToString();
    }

    public void ScoreUp (int add)
    {
        score += add;
        text.text = score.ToString();
    }
}
