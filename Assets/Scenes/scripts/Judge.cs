using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
    
    public class Judge : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] Text text;
    [SerializeField] Timer time;


    public void Setup()
    {
        obj.SetActive(false);
    }

    public void View(int i)
    {
        switch (i) 
        {
            case 1:
                text.color = Color.red;
                text.text = "success!!";
                break;
            case 2:
                text.color = Color.blue;
                text.text = "failed...";
                break;
            case 3:
                text.color = Color.cyan;
                text.text = "fantastick!!!";
                break;
            case 4:
                text.color = Color.black;
                text.text = "pass";
                break;
            case 5:
                text.color = Color.black;
                text.text = "draw";
                break;
        }
        obj.SetActive(true);
        time.Time(2);
        obj.SetActive(false);
    }
}
