using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Collections.ObjectModel;

public class RankingData : MonoBehaviour
{
    private static string FILE_NAME = "Ranking.json";
    [SerializeField]
    private List<UsernameAndPoints> usernameAndPoints;
    private string pathJson;
    private void Awake()
    {
        pathJson = Path.Combine(Application.persistentDataPath, FILE_NAME);
        if(File.Exists(pathJson))
        {
            var textJson = File.ReadAllText(pathJson);
            JsonUtility.FromJsonOverwrite(textJson, this);
        }
        else
        {
            usernameAndPoints = new List<UsernameAndPoints>();
        }
    }
    public void AddPoints(int points, string username)
    {
        var pointsAndUsername = new UsernameAndPoints(username, points);
        this.usernameAndPoints.Add(pointsAndUsername);
        saveData();
    }
    public int NumArrayElements()
    {
        return usernameAndPoints.Count;
    }
    public ReadOnlyCollection<UsernameAndPoints> GetUsernameAndPoints()
    {
        return usernameAndPoints.AsReadOnly();
    }
    private void saveData()
    {
        var textJson = JsonUtility.ToJson(this);
        File.WriteAllText(pathJson, textJson);
    }
}
[System.Serializable]
public class UsernameAndPoints
{
    public string Username;
    public int Points;

    public UsernameAndPoints(string username, int points)
    {
        Username = username;
        Points = points;
    }
}
