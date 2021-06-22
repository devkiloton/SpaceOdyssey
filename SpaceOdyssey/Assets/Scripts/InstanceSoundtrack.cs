using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceSoundtrack : MonoBehaviour
{
    private void Update()
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
