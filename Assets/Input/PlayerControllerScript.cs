using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; //ADD THIS!!

public class PlayerControllerScript : MonoBehaviour
{
    public float iJumpForce = 5;
    public float iMovementSpeed = 15;

    private Vector2 forceDirection = Vector2.zero;

    private PlayerInputActions playerInputActions; //same class name as input action script
    private InputAction movement;
    private Rigidbody2D PlayerRigidbody;

    //private InputAction jumping;


    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        PlayerRigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {   
        
        movement = playerInputActions.Player.Movement;
        movement.Enable();

        //jumping = playerInputActions.Player.Jumping;

        playerInputActions.Player.Jumping.performed += DoJump; //"subscribing" a function 'DoJump' to the 'performed' event
        playerInputActions.Player.Jumping.Enable();

        // CTRL + .  to open special magic menu or just right click


        //NO NEED TO CONSTANTLY CHECK EVERY SINGLE INPUT EVERY SINGLE FRAME WOOOOOOOOOOOOO

        //can add any extra input functions easily with the menu
        //enable/disable at will for unlockable abilities/movement restrictions from enemies...etc

    }

    private void DoJump(InputAction.CallbackContext obj)
    {
        //throw new NotImplementedException();
        
        Debug.Log("Jumped!!\n");

        forceDirection += Vector2.up * iJumpForce;

    }

    private void OnDisable()
    {
        movement.Disable();
        playerInputActions.Player.Jumping.performed -= DoJump; //dont forget to unsubscribe!
        playerInputActions.Player.Jumping.Disable();
    }


    //Handle *ALL* Physics based movement/object manip in FixedUpdate
    private void FixedUpdate()
    {
        //print out movement values for checking, vector 2 bc X and Y 
        Debug.Log("Movement values ----> " + movement.ReadValue<Vector2>() );

        forceDirection += movement.ReadValue<Vector2>() * iMovementSpeed;

        PlayerRigidbody.AddForce(forceDirection, ForceMode2D.Impulse);

        forceDirection = Vector2.zero;

    }



}
