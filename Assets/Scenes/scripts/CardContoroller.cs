using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardContoroller : MonoBehaviour
{

    CardView view;// �����ڂ̑���
    CardModel model;// �f�[�^�̑���

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
