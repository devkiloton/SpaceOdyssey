using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Scores : MonoBehaviour
{
    [SerializeField]
    private myPersonalEventInt whenScore;
    private int points;
    public void AddPoints()
    {
        points++;
        whenScore.Invoke(points);
    }
}
[System.Serializable]
public class myPersonalEventInt : UnityEvent<int>
{

}
