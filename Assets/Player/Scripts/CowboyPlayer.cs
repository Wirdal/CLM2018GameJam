using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowboyPlayer : MonoBehaviour {

    public float JumpVel = 7f;
    public int PlayerSpeed = 5;

    public bool IsGrounded;

    private bool FacingRight = true;
    private float XDir;
    private bool ExistsNewJump;
    Animator MyAnimator = null;
    Rigidbody2D Obj;

    void Awake()
    {
        Obj = gameObject.GetComponent<Rigidbody2D>();
        MyAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
        Player_Move();
    }

    void FixedUpdate()
    {
        if (ExistsNewJump){
            PlayerJump();
            ExistsNewJump = false;
        }

        Obj.velocity = new Vector2(XDir * PlayerSpeed, GetComponent<Rigidbody2D>().velocity.y);
    }

    void Player_Move(){
        // CONTROLS
        XDir = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && IsGrounded){
            ExistsNewJump = true;
            IsGrounded = false;
        }
        if (Input.GetButton("Fire1")){
            MyAnimator.SetBool("shoot", true);
        }
        else{
            MyAnimator.SetBool("shoot", false);
        }

        // DIRECTION
        if (XDir < 0.0f && FacingRight){
            FlipPlayer();
        }
        else if (XDir > 0.0f && !FacingRight){
            FlipPlayer();
        }


    }

    void PlayerJump(){
        Obj.AddForce(Vector2.up * JumpVel, ForceMode2D.Impulse);
    }

    void FlipPlayer(){
        FacingRight = !FacingRight;
        gameObject.transform.Rotate(0f, 180f, 0f);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Player has collided with " + collision.collider.name);
        if (collision.gameObject.tag == "ground"){
            Debug.Log("collided with ground");
            IsGrounded = true;
        }
    }
}
