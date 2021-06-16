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
        var quantity = ranking.NumArrayElements();
        for(var i=1; i < quantity; i++)
        {
            if (i > 5)
            {
                break;
            }
            var rank = GameObject.Instantiate(prefabRanking, this.transform);
            rank.GetComponent<RankingItem>().config(i, "Paula", 125);
        }
    }
}
