using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer1 : Movementbase
{
    public override void Update()
    {

        hor = Input.GetAxis("PlayerOneHor");
        ver = Input.GetAxis("PlayerOneVer");
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
        if (Input.GetButtonDown("Q"))
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

