using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    //Creating variables for buttons and a variable that signifies the game status
    public static bool GameIsPaused = false;
    public bool isPause;
    public bool isResume;

    void OnMouseUp()
    {
        if(isPause) //pause button sets timescale to 0 when pressed 
        {
            GameIsPaused = true;
            Time.timeScale = 0;
        }
        if(isResume && GameIsPaused == true)  //sets timescale to 1 when pressed
        {
            GameIsPaused = false;
            Time.timeScale = 1;
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
