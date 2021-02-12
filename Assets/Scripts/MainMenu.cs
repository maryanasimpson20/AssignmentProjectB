using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    

    //Declaring all the buttons as boolean to check which they are
    public bool isPlay;
    public bool isOptions;
    public bool isExit;
    public bool isLeaderboards;

    //This method is called when the button is clicked
    void OnMouseUp()
    {
        if(isPlay)
        {
            SceneManager.LoadScene("Game");
        }
        if (isOptions)
        {
            SceneManager.LoadScene("Options");
        }
        if (isLeaderboards)
        {
            SceneManager.LoadScene("Leaderboards");
        }
        if(isExit)
        {
            Application.Quit();
            Debug.Log("Exiting Game...");
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
