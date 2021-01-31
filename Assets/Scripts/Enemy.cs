using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public string x = " ";
    private BoxCollider bx;
    private SphereCollider sc;
    [SerializeField]
    private float _speed = 5f;
    // Start is called before the first frame update
    public static int score = 0;
    public Text scoreText;

    void Start()
    {
        sc = GetComponent<SphereCollider>();
        bx = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        //translate the enemy position backwards (back due to it being on the z axis)
        transform.Translate(Vector3.back * _speed * Time.deltaTime);
        //if the enemy has gone below -7.39 on the y axis
        if(transform.position.z < -3.67f)
        {
            score += 10;
            scoreText.text = "" + score; 
            //transform.position = teleport
            float randomX = Random.Range(-4.15f,4.15f);
            _speed+=0.5f;
            if(_speed >= 25f){
                _speed = 25f;
            }
            transform.position = new Vector3(randomX,0.6f,6.45f);
        }
        //change the position to teleport from the top of the screen at random position on x axis
    }

/*private void OnCollisionEnter(Collision other) {
    if(other.gameObject.tag == "Wall"){
            score += 10;
            scoreText.text = "" + score; 
            //transform.position = teleport
            float randomX = Random.Range(-4.15f,4.15f);
            _speed+=0.5f;
            if(_speed >= 25f){
                _speed = 25f;
            }
            transform.position = new Vector3(randomX,0.6f,6.45f);
    }
}*/
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ghost")
        {
            Destroy(this.gameObject);
        }
    }
    
    /*public void onCollisionEnter2D(Collision2D collision){
            destroyEnemy(collision,x);
    }

    public void destroyEnemy(Collision2D collision, string x){
        if(collision.gameObject.tag == "Ghost"){
            Destroy(this.gameObject);
            x = "Object Destroyed";
        }
    }*/
}
