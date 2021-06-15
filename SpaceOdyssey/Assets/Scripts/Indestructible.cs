using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indestructible : MonoBehaviour
{
    private void Start()
    {
        GameObject.DontDestroyOnLoad(gameObject);
    }
}
