using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector3 resetCoöridinates;
    public Vector2 panlimit;

    public bool freeCam;

    public float smoothTime = 0.4f;
    public float speed = 10;
    public float panSpeed = 60;
    public float panBorderThiccness = 30f;

    public int maxY = 1000;
    public int minY = 10;
    public int scrollspeed = 20;
    public int honderd = 100;

    public Transform target;

    public void Update()
    {
        Vector3 pos = transform.position;

        if (freeCam == true)
        {
            if (Input.GetButton("W") || Input.mousePosition.y >= Screen.height - panBorderThiccness)
            {
                pos.z += panSpeed * Time.deltaTime;
            }
            if (Input.GetButton("S") || Input.mousePosition.y <= panBorderThiccness)
            {
                pos.z -= panSpeed * Time.deltaTime;
            }
            if (Input.GetButton("D") || Input.mousePosition.x >= Screen.width - panBorderThiccness)
            {
                pos.x += panSpeed * Time.deltaTime;
            }
            if (Input.GetButton("A") || Input.mousePosition.x <= panBorderThiccness)
            {
                pos.x -= panSpeed * Time.deltaTime;
            }
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * scrollspeed * honderd * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, -panlimit.x, +panlimit.x);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        pos.z = Mathf.Clamp(pos.z, -panlimit.y, +panlimit.y);
        transform.position = pos;

        if (Input.GetButtonDown("FreeCam"))
        {
            if (freeCam == false)
            {
                freeCam = true;
                resetCoöridinates = transform.position;
            }
            else
            {
                transform.position = resetCoöridinates;
                freeCam = false;
            }
        }
    }
}
