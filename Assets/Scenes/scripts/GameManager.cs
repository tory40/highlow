using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    bool canPushButton;
    void Start()
    {
        canPushButton = true;
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
        if (deck.Count > 0)
        {
            int j = (deck[0]);
            CardContoroller card = Instantiate(cardPrefab, set, false);
            card.Init(j);
            remain.delete(j);
            cards.Add(card);
            rest.CountDown(1);
        }
        else 
        {
            canPushButton = false;
            End();
        }
    }
    public void setCreateCard(Transform set)
    {

        if (deck.Count > 1)
        {
            int j = (deck[1]);
            CardContoroller card = Instantiate(cardPrefab, set, false);
            card.Init(j);
            card.Hide();
            cards.Add(card);
        }
        else 
        {
            canPushButton = false;
            End();
        }
    }
    public void checkCreateCard(Transform set)
    {

        SoundManager.Instance.PlaySE(0);
        int j = (deck[1]);
        CardContoroller card = Instantiate(cardPrefab, set, false);
        card.Init(j);
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
        if (canPushButton)
        {
            canPushButton = false;
            StartCoroutine(OnHighCor());
        }
    }

    IEnumerator OnHighCor() 
    {
        checkCreateCard(setfiledTransform);
        yield return new WaitForSeconds(1);
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
        StartCoroutine(OnCor());
    }

    public void low()
    {
        if (canPushButton)
        {
            canPushButton = false;
            StartCoroutine(OnLowCor());
        }
    }

    IEnumerator OnLowCor() 
    {
        checkCreateCard(setfiledTransform);
        yield return new WaitForSeconds(1);
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
        StartCoroutine(OnCor());
    }
    public void same()
    {
        if (canPushButton)
        {
            canPushButton = false;
            StartCoroutine(OnSameCor());
        }
    }

    IEnumerator OnSameCor() 
    {
        checkCreateCard(setfiledTransform);
        yield return new WaitForSeconds(1);
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
        StartCoroutine(OnCor());
    }
    public void pass()
    {
        if (canPushButton)
        {
            canPushButton = false;
            StartCoroutine(OnPassCor());
        }
    }
    IEnumerator OnPassCor()
    {
        checkCreateCard(setfiledTransform);
        yield return new WaitForSeconds(1);
        through();
        StartCoroutine(OnCor());
    }

    IEnumerator OnCor() 
    {
        yield return new WaitForSeconds(2);
        DeleteCards();
        deck.RemoveAt(0);
        openCreateCard(openfiledTransform);
        setCreateCard(setfiledTransform);
        canPushButton = true;
    }
     void success() 
    {
        SoundManager.Instance.PlaySE(4);
        judge.View(1);
        Debug.Log("success");
        score.ScoreUp(10);
    }

    void failed() 
    {
        SoundManager.Instance.PlaySE(6);
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
        SoundManager.Instance.PlaySE(3);
        judge.View(3);
        Debug.Log("fantastick");
        score.ScoreUp(30);
    }
    void through() 
    {
        SoundManager.Instance.PlaySE(5);
        judge.View(4);
        Debug.Log("pass");
    }

    void draw() 
    {
        SoundManager.Instance.PlaySE(5);
        judge.View(5);
        Debug.Log("draw");
    }

    public void End() 
    {
        SceneManager.LoadScene("Ranking2");
    }
}