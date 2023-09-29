using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject player;
    public PlayerLocomotion playerLocomotion; // public class
    public InputManager inputManager;          // public class
    public static PlayerManager instance { get; private set; }
    public float moveSpeed;
    public float rotSpeed;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        playerLocomotion = player.GetComponent<PlayerLocomotion>();
        inputManager = player.GetComponent<InputManager>();
        rb = player.GetComponent<Rigidbody>();
}

    // Update is called once per frame
    void Update()
    {
        inputManager.HandleAllInput();
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else 
        {
            instance = this;
        }
    }
}

