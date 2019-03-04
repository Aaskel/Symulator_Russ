using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Echosonda : MonoBehaviour
{
    public float depth;

    RaycastHit hit;
    float opoznienie =5;
    void Update()
    {
        opoznienie += Time.deltaTime;
        if (opoznienie >= 5)
        {
            if (Physics.Raycast(transform.position, Vector3.down, out hit))
                depth = hit.distance;
            else
                depth = -1;

            opoznienie = 0;
        }
    }
}
