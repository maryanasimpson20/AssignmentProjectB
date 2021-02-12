using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    //Declaring all the buttons as boolean to check which they are
    public bool isBack;
    public bool isVisuals;
    public bool isInstructions;
    public bool isAudio;

    //This method is called when the button is clicked
    void OnMouseUp()
    {
        if(isBack)
        {
            SceneManager.LoadScene("MainMenu");
        }
        if (isVisuals)
        {
            SceneManager.LoadScene("Visuals");
        }
        if (isAudio)
        {
            SceneManager.LoadScene("Audio");
        }
        if(isInstructions)
        {
            SceneManager.LoadScene("Instructions");
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
