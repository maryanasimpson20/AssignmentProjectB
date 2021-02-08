﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPlayAgain;
    public bool isMenu;

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
