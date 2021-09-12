using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class GameProjectileSpawner : MonoBehaviour
{
    public GameProjectile projectile;
    private static float timer;
    public float spawnDelay;
    bool left;

    private PlayerInputActions playerInputActions;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;

        playerInputActions = new PlayerInputActions();

        playerInputActions.Player.Movement.performed += Direction;
        playerInputActions.Player.Movement.Enable();
        playerInputActions.Player.Destroy.performed += ToggleDestroy; //"subscribing" a function 'DoJump' to the 'performed' event
        playerInputActions.Player.Destroy.Enable();
    }

    private void OnDisable() {
        playerInputActions.Player.Movement.performed -= Direction;
        playerInputActions.Player.Movement.Disable();
        playerInputActions.Player.Destroy.performed -= ToggleDestroy; //dont forget to unsubscribe!
        playerInputActions.Player.Destroy.Disable();
    }
    void ToggleDestroy(InputAction.CallbackContext obj) {
        
            Instantiate(projectile,transform.position,Quaternion.identity).AddForce(left);
    }
    void Direction(InputAction.CallbackContext obj) {
        Vector2 dir = (Vector2 )obj.ReadValueAsObject();
        Debug.Log(dir);
        left = dir.x == -1;

    }
}