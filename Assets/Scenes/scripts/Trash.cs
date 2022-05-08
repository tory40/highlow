using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Trash : MonoBehaviour
{
    int type = Type2.Typenum;
    int count = Count2.Countnum;
    [SerializeField] GameObject[] sample;
    [SerializeField] Transform set;
    List<GameObject> trashs = new List<GameObject>();
    List<Text> trashstext = new List<Text>();
    List<int> trashsint = new List<int>();
    [SerializeField] Text sampletext;
    [SerializeField] GridLayoutGroup grid;
    public void SetUp() 
    {
        Create();
        Createtext();
        Pad(grid);
    }
    public void Pad(GridLayoutGroup grid)
    {
        //セルサイズを入力
        int sizex = 60;
        int sizey = 60;
        //全体の寸法を入力
        int wide = 160;
        int height = 460;
        //端のスペースを入力
        int i = 200 / type;
        int top = i;
        int bottom = i;
        int right = 10;
        int left = 10;
        //配置する列と団の数
        int step = 2;
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
        for (int i = 0; i < type; i++)
        {
            GameObject trash = Instantiate(sample[i], set, false);
            trashs.Add(trash);
        }
    }

    public void Createtext()
    {
        for (int i = 0; i < type; i++)
        {
            Text trashtext = Instantiate(sampletext, set, false);
            trashstext.Add(trashtext);
            trashsint.Add(0);
            trashstext[i].text = trashsint[i].ToString();
        }
    }

    public void Init(int i)
    {
        ++trashsint[i];
        trashstext[i].text = trashsint[i].ToString();
    }
}
