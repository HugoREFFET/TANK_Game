using UnityEngine;

public class mouselookat : MonoBehaviour
{
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }
    
    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 100);
        if(Physics.Raycast(ray.origin, ray.direction * 100, out var hitInfo))
        {
            var dir = hitInfo.point - transform.position;
            dir.y = 0f;
            
            var r = Quaternion.LookRotation(dir, Vector3.up);
            transform.rotation = r;
        
        }
    }
}