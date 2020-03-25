using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootScript : MonoBehaviour
{
    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 200);
        GetComponent<Rigidbody>().useGravity = true;
    }
}
 