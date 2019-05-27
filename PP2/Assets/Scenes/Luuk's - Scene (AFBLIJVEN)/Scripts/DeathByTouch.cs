using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathByTouch : MonoBehaviour
{
    public int i;
    public GameObject camReset;

    public void Start()
    {
        camReset = GameObject.FindGameObjectWithTag("MainCam");
    }
    public void OnCollisionEnter(Collision coll)
    {
        if(coll.transform.tag == "Player")
        {
            // = camReset.GetComponent<MultipleTagetCam>().targets[i];
            Destroy(coll.gameObject);
        }
    }
}
