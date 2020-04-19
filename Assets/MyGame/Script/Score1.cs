using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score1 : MonoBehaviour
{
    public static int scoreValue1 = 0;
    Text score1;

    void Start()
    {
        score1 = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        score1.text = "Score: " + scoreValue1;
    }
}
