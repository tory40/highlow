using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleStart : MonoBehaviour
{
    bool canstart = true;
    static bool playmusic = false;

    private void Start()
    {
        if (!playmusic)
        {
            playmusic = true;
            SoundManager.Instance.PlayBGM(0);
        }
    }
    public void PressStart()
    {
        if (canstart) 
        {
            canstart = false;
            SceneManager.LoadScene("DeckSerect");
        }
    }
}
