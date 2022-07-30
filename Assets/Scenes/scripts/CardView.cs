using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardView : MonoBehaviour
{
    [SerializeField] Text numberText;
    [SerializeField] Image iconImage;

    public void Show(CardModel cardModel,int cardID)
    {
        numberText.text = cardModel.number.ToString();
        Color col = Color.black;
        switch (cardID/Count2.Countnum)
        {
            case 0:
                col = Color.yellow;
                break;
            case 1:
                col = Color.red;
                break;
            case 2:
                col = Color.green;
                break;
            case 3:
                col = Color.blue;
                break;
            case 4:
                col = new Color(1.0f, 0.5f, 0.0f, 1.0f);
                break;
            case 5:
                col = Color.magenta;
                break;
            case 6:
                col = new Color(0.7f, 1.0f, 0.2f, 1.0f);
                break;
            case 7:
                col = Color.cyan;
                break;
            default:
                col = Color.black;
                break;
        }
        numberText.color = col;
        iconImage.sprite = cardModel.icon;
    }
    public void Hide() 
    {
        numberText.text = "";
    }
}
