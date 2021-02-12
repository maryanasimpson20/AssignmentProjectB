using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public string x = " ";
    private SphereCollider sc;
    [SerializeField]
    private float _speed = 5f;
    public static int score = 0;
    public Text scoreText;

    void Start()
    {
        sc = GetComponent<SphereCollider>();
    }

    void Update()
    {
        //translate the enemy position downwards
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
        //if the enemy has gone below -4.64 on the z axis
        if(transform.position.z < -4.64f)
        {
            score += 10;
            scoreText.text = "" + score; 
            
            //change the position to teleport from the top of the screen at random position on x axis
            float randomX = Random.Range(-4.9f,4.9f);
            _speed+=0.5f;
            if(_speed >= 25f){
                _speed = 25f;
            }
            transform.position = new Vector3(randomX,0.6f,6.45f);
        }
        
    }

    //Destroy the enemy when entering collision with the ghost
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ghost")
        {
            Destroy(this.gameObject);
        }
    }
}
