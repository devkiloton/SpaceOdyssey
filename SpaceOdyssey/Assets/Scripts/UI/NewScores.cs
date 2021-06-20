using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScores : MonoBehaviour
{
    [SerializeField]
    private DynamicText scoresText;
    [SerializeField]
    private RankingData ranking;
    private Scores scores;
    private int id;
    private void Start()
    {
        scores = GameObject.FindObjectOfType<Scores>();
        var totalPoints = -1;
        if (scores != null)
        {
            totalPoints = scores.Points;
        }
        scoresText.TextUpdate(totalPoints);
        id = ranking.AddPoints(totalPoints, "Name");
    }
    public void ChangeUsername(string Username)
    {
        ranking.ChangeUsername(Username, id);
    }
}
