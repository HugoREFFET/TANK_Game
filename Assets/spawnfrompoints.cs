using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class spawnfrompoints : MonoBehaviour
{

    [SerializeField] GameObject box;
    [SerializeField] private List<Transform> _points;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnABox();
    }

    private void SpawnABox()
    {
        Vector3 spawnPosition = _points[Random.Range(0, _points.Count)].transform.position;

        Instantiate(box, spawnPosition, Quaternion.identity, transform);
    }
}
