using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Trans : MonoBehaviour
{
    public Kamery kam;
    public Ship shp;
    public Slider Silnik;
    public Slider Ster;
    public GameObject silnik;
    public GameObject ster;
    private float yMyszy;
    private float xMyszy;
    private float zmiennax;
    private float zmiennay;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (kam.Camerafirst.enabled == true)
        {

            if (Input.GetKey(KeyCode.B))
            {
                yMyszy = Input.GetAxis("Mouse Y");
                if (zmiennay <= 14)
                {
                    if (yMyszy > 0)
                    {
                        zmiennay++;
                        silnik.transform.eulerAngles = new Vector3(zmiennay, 0, 0);

                    }
                }
                if (zmiennay >= -14)
                {
                    if (yMyszy < 0)
                    {
                        zmiennay--;
                        silnik.transform.eulerAngles = new Vector3(zmiennay, 0, 0);
                    }
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.V))
                {
                    xMyszy = Input.GetAxis("Mouse X");
                    if (zmiennax < 180)
                    {
                        if (xMyszy > 0)
                        {
                            zmiennax = zmiennax + 5;
                            ster.transform.eulerAngles = new Vector3(0, 0, zmiennax);

                        }
                    }

                    if (zmiennax > -180)
                    {
                        if (xMyszy < 0)
                        {
                            zmiennax = zmiennax - 5;
                            ster.transform.eulerAngles = new Vector3(0, 0, zmiennax);
                        }
                    }
                }
            }
            Silnik.value = zmiennay * 7.1428571428571428571428571428571f;
            Ster.value = zmiennax * 0.22222222222222222222222222222222f;
        }
        else
        {
            zmiennax = Ster.value / 0.22222222222222222222222222222222f;
            zmiennay = Silnik.value / 0.22222222222222222222222222222222f;
        }
    }
}
