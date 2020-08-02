using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseMenu : MonoBehaviour
{
    public GameObject optionsMenu;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            optionsMenu.gameObject.SetActive(!optionsMenu.gameObject.activeSelf);
        }
    }




    public void quitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }


}
