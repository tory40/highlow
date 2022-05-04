using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Optionopen : MonoBehaviour
{
    [SerializeField] GameObject option;
    public void Open() 
    {
        option.SetActive(true);
    }
}
