using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene(1);
    }
    public void exit()
    {
        Application.Quit();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("QUIT");
            Application.Quit();
        }
    }
}
