using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float force;
    private Rigidbody2D physics;
    private void Start()
    {
        physics = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        var wayToTarget = target.position - transform.position;
        wayToTarget = wayToTarget.normalized*force;
        physics.AddForce(wayToTarget, ForceMode2D.Force);
    }
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
