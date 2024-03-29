using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerTank : MonoBehaviour
{
    public float speed;
    
    public Rigidbody rb;
    private Vector3 moveDirection;
    private float inputDirection;
    private float turnDirection;

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