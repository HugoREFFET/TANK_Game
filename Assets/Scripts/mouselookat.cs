using UnityEngine;
using UnityEngine.InputSystem;

public class mouselookat : MonoBehaviour
{
    private float turnDirection;

    void Update()
    {
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
        transform.rotation = Quaternion.AngleAxis(-angle, Vector3.up);
    }

    void FixedUpdate()
    {
        transform.Rotate(Vector3.up, turnDirection);
    }
    public void Rotate(InputAction.CallbackContext context)
    {
        turnDirection = context.ReadValue<float>();
    }
}
