using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(Wall.topRight.x - 1, 0);
        this.rb.AddForce(new Vector2(-1000.0f, 0.0f));
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (ProjectileSpawner.destroyOnHit && other.transform.tag == "Projectile")
        {
            Destroy(this.gameObject);
        }
    }

    /*void OnTriggerEnter2D(Collider2D other) {
        if (ProjectileSpawner.destroyOnHit && other.transform.tag == "Projectile") {
            Destroy(this.gameObject);
        }
    }*/
}
