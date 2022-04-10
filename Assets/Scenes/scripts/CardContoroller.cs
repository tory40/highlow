using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardContoroller : MonoBehaviour
{

    CardView view;// Œ©‚½–Ú‚Ì‘€ì
    CardModel model;// ƒf[ƒ^‚Ì‘€ì

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
