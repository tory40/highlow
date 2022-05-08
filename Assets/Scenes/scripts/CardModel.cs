using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardModel 
{
    int count = Count2.Countnum;
    int type = Type2.Typenum;
    public int number;
    public Sprite icon;
    public CardModel(int cardID)
    {
        int cardID2 = cardID / count;
        CardEntity cardEntity = Resources.Load<CardEntity>("CardEntityList/Card"+cardID2);
        int number2 = cardID%count;
        number = number2 + 1;
        icon = cardEntity.icon;
       
    }
}