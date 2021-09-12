using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AstroMovement : MonoBehaviour
{
 
    public Rigidbody2D Player;
    public bool isJump = false;
    public Animator PlayerAnime;
    bool FacingRight;

    // Update is called once per frame
    void Update()
    {
        
        float xvelo = Input.GetAxis("Horizontal");
        PlayerAnime.SetFloat("Speed", Math.Abs(xvelo));
        Player.velocity = new Vector2(xvelo, Player.velocity.y);

        if(Player.velocity.x < 0 && !FacingRight){
            Flip();
        }
        else if(Player.velocity.x > 0 && FacingRight){
            Flip();
        }

        if(Input.GetAxis("Vertical") != 0 ) {
            Player.AddForce( new Vector2(0, 20));
            //bool isJump = true;

        }
        
        if(Player.velocity.y > 0.01){
            PlayerAnime.SetBool("IsJump", true);
        }

        else{
            PlayerAnime.SetBool("IsJump", false);
        }
        
        
    }

    void Flip(){
        FacingRight = !FacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x = theScale.x * -1;
        transform.localScale = theScale;

    }
}
