using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{
    Vector3 moveDirection;
    Transform cameraObject;

    // Start is called before the first frame update
    void Start()
    {
        cameraObject = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandlesAllMovement() 
    {
        HandlesMovement();
        HandlesRotation();
    }

    private void HandlesMovement() 
    {
        moveDirection = cameraObject.forward * PlayerManager.instance.inputManager.verticalInput;
        moveDirection += cameraObject.right   * PlayerManager.instance.inputManager.horizontalInput;
        moveDirection.Normalize();
        moveDirection.y = 0;
        moveDirection = moveDirection * PlayerManager.instance.moveSpeed;
        Vector3 movementVelocity = moveDirection;
        PlayerManager.instance.rb.velocity = movementVelocity;
    }

    private void HandlesRotation() 
    {
    
    }
}
