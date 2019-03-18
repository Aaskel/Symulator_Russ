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
        System.Random rand = new System.Random();
        double u1 = 1.0 - rand.NextDouble();
        double u2 = 1.0 - rand.NextDouble();
        double blad = ((System.Math.Sqrt(-2.0 * System.Math.Log(u1)) * System.Math.Sin(2.0 * System.Math.PI * u2)) * 0.3);
        float bladconvert = (float)blad;
        
        opoznienie += Time.deltaTime;
        Debug.Log(blad);
        Debug.Log(bladconvert);
        if (opoznienie >= 5)
        {
            if (Physics.Raycast(transform.position, Vector3.down, out hit))
                depth = hit.distance +bladconvert ;
            
            else
                depth = -1;

            opoznienie = 0;
        }
    }
}
