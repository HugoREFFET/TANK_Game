using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform target;
    public Rigidbody rb;
    public float speed;

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.parent = null;
            rb.AddForce(target.forward * speed*100, ForceMode.Impulse);
        }
    }
}