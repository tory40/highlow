using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour

{
    // カード情報の生成
    List<int> deck = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35,36 };
    [SerializeField] Transform setfiledTransform;
    [SerializeField] CardContoroller cardPrefab;
    [SerializeField] Transform openfiledTransform;
    void Start()
    {

         Shuffle();
         Cardnumber();
        startCreateCard(openfiledTransform);
        CreateCard(setfiledTransform);

    }

    void Shuffle()//カード生成後シャッフル
    {

        for (int i = 0; i < deck.Count; i++)
        {
            int temp = deck[i];
            int randomIndex = Random.Range(0, deck.Count);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = temp;

        }
    }

    void Cardnumber()
    {

        for (int i = 0; i < deck.Count; i++)
        {

            Debug.Log(deck[i]);
        }

    }

    public void startCreateCard(Transform set)
    {



        int j = (deck[0]);
        CardContoroller card = Instantiate(cardPrefab, set, false);
        card.Init(j);



    }
    public void CreateCard(Transform set)
    {


        
            int j = (deck[1]);
            CardContoroller card = Instantiate(cardPrefab, set, false);
            card.Init(j);
             
            
        
    }

    void Update()
    {


    }

    public void high() 
    {
        int j = (deck[1] % 9);
        int k = (deck[0] % 9);
        if (j == 0)
        {
            j = j + 9;
        }
        if (k == 0)
        {
            k = k + 9;
        }
        Debug.Log(j + "と" + k);
        CreateCard(openfiledTransform);
        deck.RemoveAt(0);
        CreateCard(setfiledTransform);
            if (j < k) 
        {
            failed();
        }
        else if (j > k) 
        {
            success();
        }
        else 
        {
            draw();
        }
        
    }

    public void low() 
    {
        int j = (deck[1] % 9);
        int k = (deck[0] % 9);
        if (j == 0)
        {
            j = j + 9;
        }
        if (k == 0)
        {
            k = k + 9;
        }
        Debug.Log(j + "と" + k);
        CreateCard(openfiledTransform);
        deck.RemoveAt(0);
        CreateCard(setfiledTransform);
        if (j < k)
        {
            success();
        }
        else if (j > k)
        {
            failed();
        }
        else
        {
            draw();
        }
    }

    public void same() 
    {
        int j = (deck[1] % 9);
        int k = (deck[0] % 9);
        if (j == 0)
        {
            j = j + 9;
        }
        if (k == 0)
        {
            k = k + 9;
        }
        Debug.Log(j + "と" + k);
        CreateCard(openfiledTransform);
        deck.RemoveAt(0);
        CreateCard(setfiledTransform);
        if (j == k)
        {
            fantastick();
        }
        else
        {
            failed();
        }
        
    }

    public void pass()
    {
        CreateCard(openfiledTransform);
        deck.RemoveAt(0);
        CreateCard(setfiledTransform);
        through();
    }
     void success() 
    {
        Debug.Log("success");
    }

    void failed() 
    {
        Debug.Log("failed");
    }

    void fantastick() 
    {
        Debug.Log("fantastick");
    }
    void through() 
    {
        Debug.Log("pass");
    }

    void draw() 
    {
        Debug.Log("draw");
    }
}