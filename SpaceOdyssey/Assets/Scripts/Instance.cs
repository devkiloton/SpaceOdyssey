using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instance : MonoBehaviour
{
    private void Start()
    {
        var anotherInstances = GameObject.FindGameObjectsWithTag(this.tag);
        foreach(var instance in anotherInstances)
        {
            if(instance != gameObject)
            {
                GameObject.Destroy(instance.gameObject);
            }
        }
    }
}
