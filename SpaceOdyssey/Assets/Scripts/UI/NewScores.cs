using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NewScores : MonoBehaviour
{
    [SerializeField]
    private DynamicText scoresText;
    [SerializeField]
    private RankingData ranking;
    private Scores scores;
    private string id;
    private void Start()
    {
        int totalPoints = getScores();
        scoresText.TextUpdate(totalPoints);
        id = ranking.AddPoints(totalPoints, "Name");
    }

    private int getScores()
    {
        scores = GameObject.FindObjectOfType<Scores>();
        var totalPoints = -1;
        if (scores != null)
        {
            totalPoints = scores.Points;
        }

        return totalPoints;
    }

    public void ChangeUsername(string Username)
    {
        ranking.ChangeUsername(Username, id);
    }
}