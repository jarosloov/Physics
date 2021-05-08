using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Apples : MonoBehaviour
{
    public AudioSource AppleAuduo;
    

    private void Start()
    {
        AppleAuduo = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Apple"))
        {
            Destroy(other.gameObject);
            AppleSize.appleSize++;
            AppleAuduo.Play();
        }
        
        if (other.tag.Equals("Ball1"))
        {
            FallingBall.statusRB = true;
            Debug.Log("EEEE!");
        }

        if (other.tag.Equals("Blow to the head"))
        {
            HealthBar.heatlth -= FallingBall.domage;
        }
    }
}
