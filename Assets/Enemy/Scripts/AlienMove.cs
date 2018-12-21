using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMove : MonoBehaviour {
    public int EnemySpeed;
    public int XMoveDirection;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(XMoveDirection, 0));

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(XMoveDirection, 0) * EnemySpeed;

        if (hit.distance < 0.7f){
            FlipPlayer();
        }

	}

    void FlipPlayer(){
        if (XMoveDirection > 0){
            XMoveDirection = -1;
        }
        else{
            XMoveDirection = 1;
        }
       
    }
}
