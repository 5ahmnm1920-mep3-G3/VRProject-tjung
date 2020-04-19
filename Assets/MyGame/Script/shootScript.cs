using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootScript : MonoBehaviour
{
    public Vector3 ForceVariable = new Vector3 (-150, 50, 0);
    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 200);
        GetComponent<Rigidbody>().useGravity = true;
    }

    public void Shoot()
    {
        
        
            GetComponent<Rigidbody>().AddForce(ForceVariable);
            print("yes");
        
    }
}
 