using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Playerconrol playercontrols; // calls unity's generated script
    // Start is called before the first frame update
    public Vector2 movementInput;
    public float verticalInput;
    public float horizontalInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnable()
    {
        if (playercontrols == null) 
        {
            playercontrols = new Playerconrol();
        }
        
        playercontrols.Enable();
        
        
        

    }

    private void OnDisable()
    {
        playercontrols.Disable();
    }

    public void HandleAllInput() 
    {
        HandleMovementInput();
    }
    private void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;
    }
}
