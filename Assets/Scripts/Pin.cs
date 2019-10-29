using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{ 
    public float speed = 20f;
    public Rigidbody2D rb;

    private bool isPinned= false;


    void Update() {
        if( !isPinned ){
             rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime); 
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        //Debug.Log("collide in Rotator");
        if(other.tag == "Rotator"){
          transform.SetParent(other.transform);
            isPinned= true;
            //other.GetComponent<Rotator>().speed +=20f;
        }
        else if(other.tag =="Pin"){
          FindObjectOfType<GameManager>().EndGame();
        }
    }


}
