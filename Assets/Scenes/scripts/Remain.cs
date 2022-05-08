using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Remain : MonoBehaviour
{
    [SerializeField] Transform set;
    [SerializeField] Text sample;
    List<Text> remain2 = new List<Text>();
    int count = Count2.Countnum;
    int type = Type2.Typenum;
    [SerializeField] GridLayoutGroup grid;


    public void SetUp() 
    {
        Create();
        Color2();
        Pad();
    }

    public void Pad()
    {
        //セルサイズを入力
        int sizex = 60;
        int sizey = 60;
        //全体の寸法を入力
        int wide = 600;
        int height = 460;
        //端のスペースを入力
        int i = 200 / type;
        int top = i;
        int bottom = i;
        int right = 10;
        int left = 10;
        //配置する列と団の数
        int step = count;
        int line = type;
        Vector2 size = new Vector2(sizex, sizey);
        grid.cellSize = size;
        int x;
        int y;
        grid.padding.top = top;
        grid.padding.left = left;
        grid.padding.right = right;
        grid.padding.bottom = bottom;
        if (step > 1)
        {
            x = (wide - (sizex * step) - left - right) / (step - 1);
        }
        else
        {
            x = 0;
        }
        if (line > 1)
        {
            y = (height - (sizey * line) - top - bottom) / (line - 1);
        }
        else
        {
            y = 0;
        }
        Vector2 space = new Vector2(x, y);
        grid.spacing = space;
    }
    public void Create() 
    {
        for (int i = 0; i < count * type; i++)
        {
            Text remain3 = Instantiate(sample, set, false);
            remain2.Add(remain3);
        }
    }

    public void Color2() 
    {
        int j = 0;
        if (type > 0)
        {
            for (int i = 0; i < count; i++)
            {
                ++j;
                remain2[i].text = j.ToString();
                remain2[i].color = Color.yellow;
            }
        }
        if (type > 1)
        {
            j = 0;
            for (int i = count; i < count * 2; i++)
            {
                ++j;
                remain2[i].text = j.ToString();
                remain2[i].color = Color.red;
            }
        }
        if (type > 2)
        {
            j = 0;
            for (int i = count * 2; i < count * 3; i++)
            {
                ++j;
                remain2[i].text = j.ToString();
                remain2[i].color = Color.green;
            }
        }
        if (type > 3)
        {
            j = 0;
            for (int i = count * 3; i < count * 4; i++)
            {
                ++j;
                remain2[i].text = j.ToString();
                remain2[i].color = Color.blue;
            }
        }
    }

    public void delete(int i) 
    {
        Debug.Log(i);
        if (i < 0) 
        {
            return;
        }
        Init(remain2[i]);

    }

    public void Init(Text remain) 
    {
        remain.color = Color.gray;
    }
}
