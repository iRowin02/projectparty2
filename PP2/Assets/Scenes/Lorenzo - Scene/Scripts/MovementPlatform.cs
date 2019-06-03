using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlatform : MonoBehaviour
{
    public float ver = 2;
    public float movementSpeed;
    public Vector3 v;

    public void Start()
    {
        movementSpeed = 4;
    }

    void Update()
    {
        v.y = ver;
        transform.Translate(v * Time.deltaTime * movementSpeed);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Grond")
        {
            movementSpeed = 4; 
        }
        if (other.tag == "Boven")
        {
            movementSpeed = -4;
        }
    }

}
