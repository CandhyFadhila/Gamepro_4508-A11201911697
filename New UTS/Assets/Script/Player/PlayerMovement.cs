using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    PlayerControl kontrolPlayer;
    float dir;
    bool isFaceKanan = true;

    public float JumpForce = 6;
    bool isGround;
    int TotalLoncatan = 0;
    public Transform groundCheck;
    public LayerMask groundLayer;

    public float speed = 400;
    public Rigidbody2D PlayerRB;
    public Animator Anim;

    private void Awake(){
        kontrolPlayer = new PlayerControl();
        kontrolPlayer.Enable();
        kontrolPlayer.Bawah.Move.performed += ctx => {
            dir = ctx.ReadValue<float>();
        };
        kontrolPlayer.Bawah.Jump.performed += ctx => Jump();
    }

    void FixedUpdate(){
        isGround = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
        Debug.Log(isGround);
        PlayerRB.velocity = new Vector2(dir * speed * Time.fixedDeltaTime, PlayerRB.velocity.y);
        Anim.SetFloat("speed", Mathf.Abs(dir));
        if(isFaceKanan && dir < 0 || !isFaceKanan && dir > 0){
            Flip();
        }
    }

    void Flip(){
        isFaceKanan = !isFaceKanan;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
    }

    void Jump(){
        if(isGround){
            TotalLoncatan = 0;
            PlayerRB.velocity = new Vector2(PlayerRB.velocity.x, JumpForce);
            TotalLoncatan++;
        }
        else{
            if(TotalLoncatan == 1){
                PlayerRB.velocity = new Vector2(PlayerRB.velocity.x, JumpForce);
                TotalLoncatan++;
            }
        }
    }
}
