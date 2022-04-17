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
    List<CardContoroller> cards = new List<CardContoroller>();
    [SerializeField] Score score;
    [SerializeField] Restcard rest;
    [SerializeField] Trash trash;
    [SerializeField] Remain remain;
    [SerializeField] Timer time;
    [SerializeField] Judge judge;
    void Start()
    {
        judge.Setup();
        remain.SetUp();
        trash.SetUp();
        score.Setup();
        rest.Setup();
         Shuffle();
         Cardnumber();
        openCreateCard(openfiledTransform);
        setCreateCard(setfiledTransform);

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

    public void openCreateCard(Transform set)
    {



        int j = (deck[0]);
        CardContoroller card = Instantiate(cardPrefab, set, false);
        card.Init(j,0);
        remain.delete(j);
        cards.Add(card);
        rest.CountDown(1);
    }
    public void setCreateCard(Transform set)
    {

        
            int j = (deck[1]);
            CardContoroller card = Instantiate(cardPrefab, set, false);
            card.Init(j,1);
            cards.Add(card);


    }
    
    void DeleteCards() 
    {
    
        foreach(var card in cards) 
        {
            Destroy(card.gameObject);
        }
        cards.Clear();
    }

    void Update()
    {


    }

    public void high() 
    {
        time.Time(2);
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

        DeleteCards();
        deck.RemoveAt(0);
        openCreateCard(openfiledTransform);
        setCreateCard(setfiledTransform);
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

        DeleteCards();
        deck.RemoveAt(0);
        openCreateCard(openfiledTransform);
        setCreateCard(setfiledTransform);

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
        
        
        if (j == k)
        {
            fantastick();
        }
        else
        {
            failed();
        }

        DeleteCards();
        deck.RemoveAt(0);
        openCreateCard(openfiledTransform);
        setCreateCard(setfiledTransform);
    }

    public void pass()
    {
        DeleteCards();
        deck.RemoveAt(0);
        openCreateCard(openfiledTransform);
        setCreateCard(setfiledTransform);
        
        through();
    }
     void success() 
    {
        judge.View(1);
        Debug.Log("success");
        score.ScoreUp(10);
    }

    void failed() 
    {
        judge.View(2);
        Debug.Log("failed");
        int j = (deck[2]);
        int k = (j - 1) / 9;
        trash.Init(k);
        Debug.Log(k);
        Debug.Log(deck[2]+"の削除");
        deck.RemoveAt(2);
        rest.CountDown(1);

    }

    void fantastick() 
    {
        judge.View(3);
        Debug.Log("fantastick");
        score.ScoreUp(30);
    }
    void through() 
    {
        judge.View(4);
        Debug.Log("pass");
    }

    void draw() 
    {
        judge.View(5);
        Debug.Log("draw");
    }
}