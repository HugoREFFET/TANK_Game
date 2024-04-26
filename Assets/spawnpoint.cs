using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpoint : MonoBehaviour
{
    [SerializeField] private Color Color;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color;
        Gizmos.DrawWireCube(transform.position, new Vector3(1,1,1));
    }
}
