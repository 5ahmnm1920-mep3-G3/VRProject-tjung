using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Juggle_Counter : MonoBehaviour
{
    
     void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Ball")
        {
            Debug.Log("Ball colided");
        }
    }
}
  
