using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelRanking : MonoBehaviour
{
    [SerializeField]
    private RankingData ranking;
    [SerializeField]
    private GameObject prefabRanking;
    private void Start()
    {
        var pointsAndUsername = ranking.GetUsernameAndPoints();
        for(var i=0; i < pointsAndUsername.Count; i++)
        {
            if (i >= 5)
            {
                break;
            }
            var rank = GameObject.Instantiate(prefabRanking, this.transform);
            rank.GetComponent<RankingItem>().config(i, pointsAndUsername[i].Username, pointsAndUsername[i].Points);
        }
    }
}
