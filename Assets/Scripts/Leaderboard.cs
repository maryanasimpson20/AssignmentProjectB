using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Leaderboard: MonoBehaviour
{
//Creating a variable that signifies the button
    public bool isBack;

    //This method is called when the button is clicked
    void OnMouseUp()
    {
        if(isBack)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
