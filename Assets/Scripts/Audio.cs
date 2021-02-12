using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour
{
    //Creating a variable that signifies the button
    public bool isBack;

    //This method is called when the button is clicked
    void OnMouseUp()
    {
        if(isBack)
        {
            SceneManager.LoadScene("Options");
        }
    }
    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
