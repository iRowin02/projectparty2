using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer2 : Movementbase

{

    public override void Update()
    {
        hor = Input.GetAxis("PlayerTwoHor");
        ver = Input.GetAxis("PlayerTwoVer");
        movement.x = hor;
        movement.z = ver;
        base.Update();

        if (isGrounded == true)
        {
            Jump();
        }
    }

    public void Jump()
    {
        if (Input.GetButtonDown("/"))
        {
            GetComponent<Rigidbody>().velocity += jumpPower;
            isGrounded = false;
        }
    }

    public void OnCollisionEnter(Collision coll)
    {
        isGrounded = true;
    }
}

