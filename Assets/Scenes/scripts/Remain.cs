using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Remain : MonoBehaviour
{
    [SerializeField] Text remain1;
    [SerializeField] Text remain2;
    [SerializeField] Text remain3;
    [SerializeField] Text remain4;
    [SerializeField] Text remain5;
    [SerializeField] Text remain6;
    [SerializeField] Text remain7;
    [SerializeField] Text remain8;
    [SerializeField] Text remain9;
    [SerializeField] Text remain10;
    [SerializeField] Text remain11;
    [SerializeField] Text remain12;
    [SerializeField] Text remain13;
    [SerializeField] Text remain14;
    [SerializeField] Text remain15;
    [SerializeField] Text remain16;
    [SerializeField] Text remain17;
    [SerializeField] Text remain18;
    [SerializeField] Text remain19;
    [SerializeField] Text remain20;
    [SerializeField] Text remain21;
    [SerializeField] Text remain22;
    [SerializeField] Text remain23;
    [SerializeField] Text remain24;
    [SerializeField] Text remain25;
    [SerializeField] Text remain26;
    [SerializeField] Text remain27;
    [SerializeField] Text remain28;
    [SerializeField] Text remain29;
    [SerializeField] Text remain30;
    [SerializeField] Text remain31;
    [SerializeField] Text remain32;
    [SerializeField] Text remain33;
    [SerializeField] Text remain34;
    [SerializeField] Text remain35;
    [SerializeField] Text remain36;

    public void SetUp() 
    {
        remain1.color = Color.yellow;
        remain2.color = Color.yellow;
        remain3.color = Color.yellow;
        remain4.color = Color.yellow;
        remain5.color = Color.yellow;
        remain6.color = Color.yellow;
        remain7.color = Color.yellow;
        remain8.color = Color.yellow;
        remain9.color = Color.yellow;
        remain10.color = Color.red;
        remain11.color = Color.red;
        remain12.color = Color.red;
        remain13.color = Color.red;
        remain14.color = Color.red;
        remain15.color = Color.red;
        remain16.color = Color.red;
        remain17.color = Color.red;
        remain18.color = Color.red;
        remain19.color = Color.green;
        remain20.color = Color.green;
        remain21.color = Color.green;
        remain22.color = Color.green;
        remain23.color = Color.green;
        remain24.color = Color.green;
        remain25.color = Color.green;
        remain26.color = Color.green;
        remain27.color = Color.green;
        remain28.color = Color.blue;
        remain29.color = Color.blue;
        remain30.color = Color.blue;
        remain31.color = Color.blue;
        remain32.color = Color.blue;
        remain33.color = Color.blue;
        remain34.color = Color.blue;
        remain35.color = Color.blue;
        remain36.color = Color.blue;
    }

    public void delete(int i) 
    {

        switch (i) 
        {
            case 1:
                Init(remain1);
                break;
            case 2:
                Init(remain2);
                break;
            case 3:
                Init(remain3);
                break;
            case 4:
                Init(remain4);
                break;
            case 5:
                Init(remain5);
                break;
            case 6:
                Init(remain6);
                break;
            case 7:
                Init(remain7);
                break;
            case 8:
                Init(remain8);
                break;
            case 9:
                Init(remain9);
                break;
            case 10:
                Init(remain10);
                break;
            case 11:
                Init(remain11);
                break;
            case 12:
                Init(remain12);
                break;
            case 13:
                Init(remain13);
                break;
            case 14:
                Init(remain14);
                break;
            case 15:
                Init(remain15);
                break;
            case 16:
                Init(remain16);
                break;
            case 17:
                Init(remain17);
                break;
            case 18:
                Init(remain18);
                break;
            case 19:
                Init(remain19);
                break;
            case 20:
                Init(remain20);
                break;
            case 21:
                Init(remain21);
                break;
            case 22:
                Init(remain22);
                break;
            case 23:
                Init(remain23);
                break;
            case 24:
                Init(remain24);
                break;
            case 25:
                Init(remain25);
                break;
            case 26:
                Init(remain26);
                break;
            case 27:
                Init(remain27);
                break;
            case 28:
                Init(remain28);
                break;
            case 29:
                Init(remain29);
                break;
            case 30:
                Init(remain30);
                break;
            case 31:
                Init(remain31);
                break;
            case 32:
                Init(remain32);
                break;
            case 33:
                Init(remain33);
                break;
            case 34:
                Init(remain34);
                break;
            case 35:
                Init(remain35);
                break;
            case 36:
                Init(remain36);
                break;
            default:
                Debug.Log("ë∂ç›ÇµÇ»Ç¢ÉfÅ[É^");
                break;

        }
    }

    public void Init(Text remain) 
    {
        remain.color = Color.gray;
    }
}
