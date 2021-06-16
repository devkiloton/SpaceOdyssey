using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingItem : MonoBehaviour
{
    [SerializeField]
    private Text textRankScores;
    [SerializeField]
    private Text textNameRankScores;
    [SerializeField]
    private Text textPositionRank;
    public void config(int rankScores, string rankName, int positionRank)
    {
        textRankScores.text = rankScores.ToString();
        textNameRankScores.text = rankName;
        textPositionRank.text = positionRank.ToString();
    }
}
