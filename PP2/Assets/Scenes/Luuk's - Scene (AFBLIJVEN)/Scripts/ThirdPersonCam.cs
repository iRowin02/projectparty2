using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCam : MonoBehaviour
{
    private const float Y_ANGLE_MIN = 0f;
    private const float Y_ANGLE_MAX = 50f;
    private const float X_ANGLE_MIN = -80f;
    private const float X_ANGLE_MAX = 80f;
    public Transform lookAt;
    public Transform cam;

    public Camera camBam;

    private float distance = 10f;
    private float currentX = 0f;
    private float currentY = 0f;

    void Start()
    {
        cam = transform;
        camBam = Camera.main;
    }

    void Update()
    {
        currentX += Input.GetAxis("Mouse X");
        currentY += Input.GetAxis("Mouse Y");
        currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
        currentX = Mathf.Clamp(currentX, X_ANGLE_MIN, X_ANGLE_MAX);
    }

    public void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        cam.position = lookAt.position + rotation * dir;
        cam.LookAt(lookAt.position);
    }
}
