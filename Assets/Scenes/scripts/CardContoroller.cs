using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardContoroller : MonoBehaviour
{

    CardView view;// 見た目の操作
    CardModel model;// データの操作

    private void Awake()
    {
        view = GetComponent<CardView>();
    }

    public void Init(int cardID,int i)
    {
        
        model = new CardModel(cardID);
        view.Show(model,i);
        
    }
}
