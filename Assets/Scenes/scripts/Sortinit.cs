using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sortinit : MonoBehaviour
{
    [SerializeField] public static GridLayoutGroup grid;
    public void Pad() 
    {
        //セルサイズを入力
        int sizex = 0;
        int sizey = 0;
        //全体の寸法を入力
        int wide = 0;
        int height = 0;
        //端のスペースを入力
        int top = 0;
        int bottom = 0;
        int right = 0;
        int left = 0;
        //配置する列と団の数
        int step = 0;
        int line = 0;
        Sort.Instance.Pad(sizex,sizey,wide,height,top,bottom,right,left,step,line,grid);
    }

    public void Space() 
    {
        //セルサイズを入力
        int sizex = 0;
        int sizey = 0;
        //全体の寸法を入力
        int wide = 0;
        int height = 0;
        //オブジェクトのスペースを入力
        int widespase = 0;
        int heigtspase = 0;
        //配置する列と団の数
        int step = 0;
        int line = 0;
        Sort.Instance.Space(sizex,sizey,wide,height,widespase,heigtspase,step,line,grid);
    }

    public void Count() 
    {
        //全体の寸法を入力
        int wide = 0;
        int height = 0;
        //オブジェクトの数を入力
        int count = 0;
        //オブジェクト、スペースの比率を入力
        float objxper = 0;
        float objyper = 0;
        float spaceper = 0;
        Sort.Instance.Count(wide,height,count,objxper,objyper,spaceper,grid);
    }
}
