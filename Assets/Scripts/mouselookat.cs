using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class mouselookat : MonoBehaviour
{
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 100);
        if(Physics.Raycast(ray.origin, ray.direction * 100, out var hitInfo))
        {
            Debug.Log("touche");
            var dir = hitInfo.point - transform.position;
            dir.y = 0f;
            
            var r = Quaternion.LookRotation(dir, Vector3.up);

        transform.rotation = r;
        
        }




        
        
        
        
    }
}