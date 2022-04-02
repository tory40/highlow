using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardModel 
{
    public int number;
    public Sprite icon;
    public CardModel(int cardID)
    {
        CardEntity cardEntity = Resources.Load<CardEntity>("CardEntityList/Card"+cardID);
        number = cardEntity.number;
        icon = cardEntity.icon;
       
    }
}