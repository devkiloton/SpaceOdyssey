using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEvent : MonoBehaviour {

    [SerializeField]
    private UnityEvent aoBater;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.aoBater.Invoke();
        Destroy(gameObject);
    }
}
