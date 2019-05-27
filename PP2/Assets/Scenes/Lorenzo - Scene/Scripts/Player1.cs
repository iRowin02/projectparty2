using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float speed;
    public Transform target;
    private int wavePointIndex = 0;
    public int waypointsToGo;
    public GameObject playerManager;

    void Start()
    {
        //Start
        speed = 0f;
        target = Waypoints.waypoints[0];
        waypointsToGo = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PionMovement>().randomNumber;
        playerManager = GameObject.FindGameObjectWithTag("PlayerManager");
    }

    void Update()
    {
        //Movement Waypoints
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (waypointsToGo == 0)
        {
            speed = 0f;
        }

        if (waypointsToGo != 0)
        {
            if (Vector3.Distance(transform.position, target.position) <= 0.2f)
            {
                GetNextWaypoint();
                waypointsToGo--;
                playerManager.GetComponent<PionMovement>().randomNumber--;
            }
            if (wavePointIndex == 13)
            {
                wavePointIndex = -1;
            }
            if (waypointsToGo <= 0)
            {
                GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PionMovement>().Check();
            }
        }
        void GetNextWaypoint()
        {
            wavePointIndex++;
            target = Waypoints.waypoints[wavePointIndex];
        }
    }
}
