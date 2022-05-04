using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rankingclose : MonoBehaviour
{
    bool canclose = true;
    public void Close()
    {
        if (canclose)
        {
            canclose = false;
            SceneManager.LoadScene("title");
        }
    }

}
