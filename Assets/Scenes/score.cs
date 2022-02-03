using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public int scores;
    public Text scoreDisplay;


    private void Update()
    {

        scoreDisplay.text = scores.ToString();

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle")) 
        {
            //add score
            scores++;
            Debug.Log(scores); 
        }
    }
}
