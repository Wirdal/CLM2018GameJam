using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowboyJump : MonoBehaviour {

    Rigidbody2D obj;
    public float fallMult = 20f;
    public float lowJumpPower = 7f;

    void Awake()
    {
        obj = gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (obj.velocity.y < 0)
        {
            obj.gravityScale = fallMult;
        }
        else if (obj.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            obj.gravityScale = lowJumpPower;
        }
        else
        {
            obj.gravityScale = 1f;
        }
    }
}
