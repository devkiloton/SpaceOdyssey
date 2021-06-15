using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelRanking : MonoBehaviour
{
    [SerializeField]
    private RankingData ranking;
    [SerializeField]
    private GameObject prefabRanking;
    private void Start()
    {
        var quantity = ranking.NumArrayElements();
        for(var i=0; i < quantity; i++)
        {
            GameObject.Instantiate(prefabRanking, this.transform);
        }
    }
}
