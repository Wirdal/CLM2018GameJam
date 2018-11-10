using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cowboy_Player : MonoBehaviour {

    public float jumpVel = 7f;
    public int playerSpeed = 5;

    public bool isGrounded;

    private bool facingRight = true;
    private float xDir;
    private bool existsNewJump;
    
    Rigidbody2D obj;

    void Awake()
    {
        obj = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
        Player_Move();
	}

    void FixedUpdate()
    {
        if (existsNewJump){
            PlayerJump();
            existsNewJump = false;
        }

        obj.velocity = new Vector2(xDir * playerSpeed, GetComponent<Rigidbody2D>().velocity.y);
    }

    void Player_Move(){
        // CONTROLS
        xDir = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && isGrounded){
            existsNewJump = true;
            isGrounded = false;
        }
        // DIRECTION
        if (xDir < 0.0f && facingRight){
            FlipPlayer();
        }
        else if (xDir > 0.0f && !facingRight){
            FlipPlayer();
        }


    }

    void PlayerJump(){
        obj.AddForce(Vector2.up * jumpVel, ForceMode2D.Impulse);
    }

    void FlipPlayer(){
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale; 
        localScale.x *= -1; // flip horizontally
        gameObject.transform.localScale = localScale;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Player has collided with " + collision.collider.name);
        if (collision.gameObject.tag == "ground"){
            Debug.Log("collided with ground");
            isGrounded = true;
        }
    }
}
