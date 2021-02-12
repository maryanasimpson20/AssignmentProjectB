using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //Creating a variable that signifies the button
    public bool isPlayAgain;
    public bool isMenu;

    //This method is called when the button is clicked
    void OnMouseUp()
    {
        if(isPlayAgain)
        {
            SceneManager.LoadScene("Game");
            Enemy.score = 0;  
        }
        if(isMenu)
        {
            SceneManager.LoadScene("MainMenu");
            Enemy.score = 0; 
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
