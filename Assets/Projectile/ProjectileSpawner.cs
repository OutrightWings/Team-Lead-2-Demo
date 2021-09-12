using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class ProjectileSpawner : MonoBehaviour
{
    public GameObject projectile;
    private static float timer;
    public float spawnDelay;
    public static bool destroyOnHit;

    private PlayerInputActions playerInputActions;
    // Start is called before the first frame update
    void Start()
    {
        //this.topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        transform.position = new Vector2(Wall.topRight.x - 0.5f, 0);
        timer = 0.0f;
        destroyOnHit = false;
        Debug.Log("Destroy On Hit is now " + destroyOnHit);

        playerInputActions = new PlayerInputActions();

        playerInputActions.Player.Destroy.performed += ToggleDestroy; //"subscribing" a function 'DoJump' to the 'performed' event
        playerInputActions.Player.Destroy.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnDelay)
        {
            Instantiate(projectile);
            timer = 0.0f;
        }
    }

    void ToggleDestroy(InputAction.CallbackContext obj) {
        destroyOnHit = !destroyOnHit;
        Debug.Log("Destroy On Hit is now " + destroyOnHit);
    }
}