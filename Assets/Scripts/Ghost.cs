using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ghost : MonoBehaviour
{
    //private Vector2 direction;
    private Vector3 direction;
    Rigidbody rb;
    public float speed;
    public float dirY, dirZ;
//Use below for initialization
    void Start() {
      rb = GetComponent<Rigidbody>();
    }
    //Update is called once per frame
    void Update() {
      speed = 38f;
      if(Input.GetAxis("Horizontal")<0){
        //direction = Vector3.left;
        rb.AddForce (Vector3.left * speed);//changing the direction of Ghost to left
      }
        
      if(Input.GetAxis("Horizontal")>0){
        //direction = Vector3.right; //changing the direction of Ghost to right
        rb.AddForce (Vector3.right * speed);
       }
      
      if(Input.GetAxis("Vertical")<0){
        //direction = Vector3.back; //changing the direction of Ghost to down
        rb.AddForce (Vector3.back * speed);
      }

      if(Input.GetAxis("Vertical")>0){
        //direction = Vector3.forward; //changing the direction of Ghost to up
        rb.AddForce (Vector3.forward * speed);
      }


      //rb.velocity = direction*speed;
       
      /*dirX = Input.GetAxis("Horizontal") * moveSpeed;
      dirZ = Input.GetAxis("Vertical") * moveSpeed;*/
    }
      void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "Enemy"){
          Destroy(this.gameObject);
          SceneManager.LoadScene("Game Over");
        }
      }
    /*private void FixedUpdate() {
      {
        rb.velocity = new Vector3(rb.velocity.x, dirY, dirZ);
      }
    } */
}