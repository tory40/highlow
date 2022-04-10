using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Trash : MonoBehaviour
{

    [SerializeField] Text trashaxe;
    [SerializeField] Text trashbeast;
    [SerializeField] Text trashsickle;
    [SerializeField] Text trashice;

    int axe = 0;
    int beast = 0;
    int sickle = 0;
    int ice = 0;

    public void SetUp()
    {
        axe = 0;
        trashaxe.text = axe.ToString();
        beast = 0;
        trashbeast.text = beast.ToString();
        sickle = 0;
        trashsickle.text = sickle.ToString();
        ice = 0;
        trashice.text = ice.ToString();

    }
    public void Init(int k)
    {
        switch (k)
        {
            case 0:
                Axe(1);
                break;
            case 1:
                Beast(1);
                break;
            case 2:
                Sickle(1);
                break;
            case 3:
                Ice(1);
                break;
            default:
                Debug.Log("ÉGÉâÅ[");
                break;

        }
    }

    public void Axe(int add)
    {
        axe += add;
        trashaxe.text = axe.ToString();
    }

    public void Beast(int add)
    {
        beast += add;
        trashbeast.text = beast.ToString();
    }

    public void Sickle(int add)
    {
        sickle += add;
        trashsickle.text = sickle.ToString();
    }

    public void Ice(int add)
    {
        ice += add;
        trashice.text = ice.ToString();
    }
}
