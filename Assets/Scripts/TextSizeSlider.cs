using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSizeSlider : MonoBehaviour
{
    // text size (Not implemented)
    // public class slide : MonoBehaviour
    // {
        public Text text; 

        public void ChangeFontSize(float value) //Allow player to change their font size using slider
        {    
            ChangeFontSize( Mathf.RoundToInt( value ) ) ;
        }

        public void ChangeFontSize(int value)
        {    
            text.fontSize = value;    
        }
    //}
}
