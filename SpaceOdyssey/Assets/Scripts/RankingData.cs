using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class RankingData : MonoBehaviour
{
    private static string FILE_NAME = "Ranking.json";
    [SerializeField]
    private List<int> points;
    private string pathJson;
    private void Awake()
    {
        points = new List<int>();
        pathJson = Path.Combine(Application.persistentDataPath, FILE_NAME);
        var textJson = File.ReadAllText(pathJson);
        JsonUtility.FromJsonOverwrite(textJson, this);
    }
    public void AddPoints(int points)
    {
        this.points.Add(points);
        saveData();
    }
    public int NumArrayElements()
    {
        return points.Count;
    }
    private void saveData()
    {
        var textJson = JsonUtility.ToJson(this);
        File.WriteAllText(pathJson, textJson);
    }
}
