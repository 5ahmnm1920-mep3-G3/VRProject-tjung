using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Juggle_Counter1 : MonoBehaviour
{
    
     void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "BallCollider")
        {
            Debug.Log("Ball colided");
            Score1.scoreValue1 += 1;
        }
        
    }

}
  
