using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Juggle_Counter : MonoBehaviour
{
    
     void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Collider")
        {
            Debug.Log("Ball colided");
            Score.scoreValue += 1;
        }
        
    }

    void OnCollisionEnter(Collision collision)
     {
        if(collision.gameObject.tag == "Ground")
        {
            Debug.Log("Ground collision, reset score");
            Score.scoreValue = 0;

            
        }
        
    }
}
  
