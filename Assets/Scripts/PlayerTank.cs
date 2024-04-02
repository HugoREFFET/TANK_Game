using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerTank : MonoBehaviour
{
    public float speed;
    
    public Rigidbody rb;
    public Vector3 moveDirection;
    public float inputDirection;
    public float turnDirection;

    void Update()
    {
        
    }

    void FixedUpdate ()
    {
        moveDirection = (transform.forward * inputDirection).normalized;
        rb.AddForce(moveDirection * speed, ForceMode.Force);
        
        transform.Rotate(Vector3.up, turnDirection);
    }
    
    public void Move(InputAction.CallbackContext context)
    {
        inputDirection = context.ReadValue<float>();
    }

    public void Rotate(InputAction.CallbackContext context)
    {
        turnDirection = context.ReadValue<float>();
    }
}