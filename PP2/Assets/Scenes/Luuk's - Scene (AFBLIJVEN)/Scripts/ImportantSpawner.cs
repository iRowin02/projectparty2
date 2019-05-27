using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantSpawner : MonoBehaviour
{
    public GameObject g;
    public Vector3 v;

    public int amount = 1000;

    private void Start()
    {
        v.z = 30;
        v.x = 50;
        v.y = 1;
        for (int i = 0; i < amount; i++)
        {
            Instantiate(g, v, Quaternion.identity);
            v.x += 1;
            if (v.x == 60)
            {
                v.x -= 10;
                v.y += 1;
            }
            if (v.y == 10)
            {
                v.y = 0;
                v.z += 1;
            }
        }
    }
}
