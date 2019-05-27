using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerTwo : RollingScript
{
    public override void FixedUpdate()
    {
        horMove = Input.GetAxis("PlayerTwoHor");
        verMove = Input.GetAxis("PlayerTwoVer");
        base.FixedUpdate();
    }
}
