using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitGame : MonoBehaviour
{

    private void Update()
    {
        quit();
    }


    public void quit()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        { 
            Debug.Log("QUIT");
            Application.Quit();
        }
    }
}
