using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerOne : RollingScript
{
    public override void FixedUpdate()
    {
        horMove = Input.GetAxis("PlayerOneHor");
        verMove = Input.GetAxis("PlayerOneVer");
        base.FixedUpdate();
    }
}
