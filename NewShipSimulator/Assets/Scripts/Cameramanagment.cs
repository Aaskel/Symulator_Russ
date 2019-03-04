using UnityEngine;

public class Kamery : MonoBehaviour
{
    public GameObject Camerafirst, Camera, canvas,statek;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Camerafirst.SetActive(!Camerafirst.activeSelf);
            Camera.SetActive(!Camera.activeSelf);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            canvas.SetActive(true);
            statek.SetActive(false);
        }
    }
}