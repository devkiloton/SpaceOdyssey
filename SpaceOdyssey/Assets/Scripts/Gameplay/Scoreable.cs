using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreable : MonoBehaviour
{
    private Scores scores;
    public void AddPoints()
    {
        this.scores.AddPoints();
    }
    public void SetScores(Scores scores)
    {
        this.scores = scores;
    }
}
