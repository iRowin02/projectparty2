using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlatform : MonoBehaviour
{
    public float min = 1f;
    public float max = 20f;

    void Start()
    {
        min = transform.position.y;
        max = transform.position.y;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * 2, max - min) + min, transform.position.z);
    }
}
