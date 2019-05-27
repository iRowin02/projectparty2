using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingScript : MonoBehaviour
{
    public Vector3 vel;
    public float speed = 150;
    public float horMove;
    public float verMove;

    public virtual void FixedUpdate()
    {
        Vector3 movement = new Vector3(horMove, 0.0f, verMove);
        gameObject.GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }

    public virtual void OnCollisionEnter(Collision col)
    {
        if(col.transform.tag == "OtherPlayer")
        {
            vel = col.gameObject.GetComponent<Rigidbody>().velocity;
        }
    }
}
