using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sort : MonoBehaviour
{
    public static Sort Instance;

    public void Pad(int sizex,int sizey,int wide,int height, int top, int bottom, int right, int left,int step, int line, GridLayoutGroup grid) 
    {
        Vector2 size = new Vector2(sizex,sizey);
        grid.cellSize = size;
            int x;
            int y;
            grid.padding.top = top;
            grid.padding.left = left;
            grid.padding.right = right;
            grid.padding.bottom = bottom;
            if (step>1) 
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
            Vector2 space = new Vector2(x,y);
            grid.spacing = space;
    }
    public void Space(int sizex,int sizey,int wide,int height,int widespase,int heigtspase,int step,int line,GridLayoutGroup grid) 
    {
        Vector2 size = new Vector2(sizex, sizey);
        grid.cellSize = size;
        Vector2 space = new Vector2(widespase, heigtspase);
        grid.spacing = space;
        int x = (wide - (sizex * step) - (widespase * (step - 1))) / 2;
        int y = (height - (sizey * line) - (heigtspase * (line - 1))) / 2;
        grid.padding.top = y;
        grid.padding.left = y;
        grid.padding.right = x;
        grid.padding.bottom = x;
    }
    public void Count(int wide,int height,int count,float objxper,float objyper,float spaceper,GridLayoutGroup grid) 
    {
        float xper = (objxper + spaceper)/wide;
        float yper = (objyper + spaceper)/height;
        int step = 1;
        int line = 1;
        Vector2 size;
        Vector2 space;
        float x;
        float y;
        float i;
        while (true) 
        {

            if(count > step * line) 
            {
                if (xper*step<yper*line) 
                {
                    ++step;
                }
                else 
                {
                    ++line;
                }
                continue;
            }
            break;
        }
        if (xper * step < yper * line) 
        {
            y = ((height / line)*objyper)/(objyper+spaceper);
            i = y * spaceper / objyper;
            x = y * objxper / objyper;
            size = new Vector2(x,y);
            space = new Vector2(i, i);

        }
        else 
        {
            x = ((wide / step) * objxper) / (objxper + spaceper);
            i = x * spaceper / objxper;
            y = x * objyper / objxper;
            size = new Vector2(x, y);
            space = new Vector2(i, i);
        }
        grid.cellSize = size;
        grid.spacing = space;
        float j = (wide - (x * step) - (i * (step - 1))) / 2;
        float k = (height - (y * line) - (i * (line - 1))) / 2;
        grid.padding.top = (int)k;
        grid.padding.left = (int)k;
        grid.padding.right = (int)j;
        grid.padding.bottom = (int)j;
    }

}

