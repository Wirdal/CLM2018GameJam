using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowboyJump : MonoBehaviour {

    Rigidbody2D Obj;
    public float FallMult = 20f;
    public float LowJumpPower = 7f;

    void Awake()
    {
        Obj = gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Obj.velocity.y < 0)
        {
            Obj.gravityScale = FallMult;
        }
        else if (Obj.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            Obj.gravityScale = LowJumpPower;
        }
        else
        {
            Obj.gravityScale = 1f;
        }
    }
}
