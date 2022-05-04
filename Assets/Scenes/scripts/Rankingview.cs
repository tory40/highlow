using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rankingview : MonoBehaviour
{
    bool canstart = true;
    public void PressRanking()
    {
        if (canstart)
        {
            canstart = false;
            SceneManager.LoadScene("Ranking2");
        }
    }
}
