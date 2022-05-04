using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;

public class Ranking : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(Score.score);
    }

}
