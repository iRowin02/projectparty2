using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movementbase : MonoBehaviour
{
    public Vector3 movement;
    public Vector3 jumpPower = new Vector3(0, 7, 0);

    public float hor;
    public float ver;

    public int movementSpeed = 5;

    public bool isGrounded;

    public virtual void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public virtual void Update()
    {
        Vector3 movement1 = new Vector3(hor, 0.0f, ver);
        transform.rotation = Quaternion.LookRotation(movement);
        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);

        if (Input.GetButton("Cancel"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
