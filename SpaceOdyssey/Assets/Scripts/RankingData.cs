using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Collections.ObjectModel;
using System;

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
    public string AddPoints(int points, string username)
    {
        var id = Guid.NewGuid().ToString();
        var pointsAndUsername = new UsernameAndPoints(username, points, id);
        this.usernameAndPoints.Add(pointsAndUsername);
        this.usernameAndPoints.Sort();
        saveData();
        return id;
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
        Debug.Log(pathJson);
    }
    public void ChangeUsername(string username, string id)
    {
        foreach(var item in usernameAndPoints)
        {
            if (item.Id == id)
            {
                item.Username = username;
                break;
            }
        }
        saveData();
    }
}
[System.Serializable]
public class UsernameAndPoints : IComparable
{
    public string Username;
    public int Points;
    public string Id;
    public UsernameAndPoints(string username, int points, string id)
    {
        Username = username;
        Points = points;
        Id = id;
    }

    public int CompareTo(object obj)
    {
        UsernameAndPoints anotherObject = obj as UsernameAndPoints;
        return anotherObject.Points.CompareTo(Points);
    }
}
