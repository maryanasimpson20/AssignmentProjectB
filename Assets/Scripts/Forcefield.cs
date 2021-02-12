using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forcefield : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //We were working on it but not implemented
    //Forcefield around ghost "scares" (destroys) ghosthunter
    void OnTriggerEnter(Collider other) 
    {
        // Debug.Log("hit: " + other.transform.name);
        if(other.tag == "Forcefield" )
        {
            //the enemy
            Destroy(this.gameObject);

        }
    }
}
