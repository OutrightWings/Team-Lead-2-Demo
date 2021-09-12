using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProjectile : MonoBehaviour
{
    public Rigidbody2D rb;
    int lifeC = 0;
    public int life;
   
    public void AddForce(bool left) {
        rb.AddForce(new Vector2(left ? -1000f : 1000f, 0.0f));
    }
    private void Update() {
        lifeC++;
        if (lifeC > life)
            Destroy(gameObject);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Projectile" || other.transform.tag == "enemy")
        {
            Destroy(this.gameObject);
            other.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
