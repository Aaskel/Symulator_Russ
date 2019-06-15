using UnityEngine;

public class Kamery : MonoBehaviour
{

    public Camera Camerafirst;
    public Camera Bird;
    public void Start()
    {
        Camerafirst = Camerafirst.GetComponent<Camera>();
        Bird = Bird.GetComponent<Camera>();
        Camerafirst.enabled = false;
        Bird.enabled = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && Bird.enabled == true)
        {
            Bird.enabled = false;

            Camerafirst.enabled = true;

        }
        else
        {
            if (Input.GetKeyDown(KeyCode.C) && Bird.enabled == false)
            {

                Bird.enabled = true;
                Camerafirst.enabled = false;

            }
        }





    }
}