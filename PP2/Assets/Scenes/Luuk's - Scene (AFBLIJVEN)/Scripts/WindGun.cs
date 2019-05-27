using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindGun : MonoBehaviour
{
    public float range = 250f;
    public float kleurTime = 20f;
    private float bulletForce = .05f;
    public float scaleLimit = 10.0f;
    public float z = 10f;


    private int fireAmount = 30;
    public int shotPoint = 1;

    public Vector3 rotatingBoi;
    public Vector3 launch;

    public Color kleur;

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            for (int i = 0; i < fireAmount; i++)
            {
                ShootRay();
            }
        }
    }

    void ShootRay()
    {
        float randomRadius = Random.Range(0, scaleLimit);

        float randomAngle = Random.Range(0, 2 * Mathf.PI);

        Vector3 direction = new Vector3(
            randomRadius * Mathf.Cos(randomAngle),
            randomRadius * Mathf.Sin(randomAngle),
            z
        );

        direction = transform.TransformDirection(direction.normalized);


        Ray r = new Ray(transform.position, direction);
        RaycastHit hit;
        if (Physics.Raycast(r, out hit))
        {
            Debug.DrawLine(transform.position, hit.point, kleur);
            Debug.Log(hit.transform.name);

            launch.y = 0.1f;
            launch.x = 0.2f;
            rotatingBoi.z = 0.4f;
            rotatingBoi.y = 0.4f;

            if (hit.transform.GetComponent<Rigidbody>() != null)
            {
                hit.transform.GetComponent<Rigidbody>().velocity += transform.forward * bulletForce;
                hit.transform.transform.Rotate(rotatingBoi);

            }
        }
    }
}
