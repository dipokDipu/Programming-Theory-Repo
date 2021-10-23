using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{


    private void Start()
    {
    }

    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ScoreTag"))
        {
            gameObject.transform.parent = other.gameObject.transform.parent;
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plane"))
        {
            if(!BoxController.instance.GameOver)
            {
                UIHandler.instance.count -= 1;
                UIHandler.instance.CounterText.text = "Life Remaining: " + UIHandler.instance.count;
            }
            
        }
    }
}
