using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Apples : MonoBehaviour
{
    public AudioSource AppleAuduo;
    public GameObject firstPlate;
    //private int numer = 0;
    public static bool statusChest;
    
    private void Start()
    {
        AppleAuduo = GetComponent<AudioSource>();
        firstPlate.SetActive(false);
        statusChest = false;
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Q)) 
            firstPlate.SetActive(false);
    }

    public  void Continue()
    {
        firstPlate.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<FoldingApples>())
        {
            statusChest = true;
            Debug.Log(statusChest);
            AppleSize.appleSize = 0;
        }
        
        if (!other.GetComponent<FoldingApples>())
        {
            statusChest = false;
            Debug.Log(statusChest);
        }
        
        
        if (other.GetComponent<ChestSpawn>())
        {
            Debug.Log("RRR");
        }
        
        if (other.tag.Equals("Apple"))
        {
            Destroy(other.gameObject);
            AppleSize.appleSize++;
            AppleAuduo.Play();
        }
        
        if (other.tag.Equals("Ball1"))
        {
            FallingBall.statusRB = true;
        }

        if (other.tag.Equals("BlowToTheHead"))
        {
            HealthBar.heatlth -= FallingBall.domage;
        }

        if (other.tag.Equals("FirstPlate"))
        {
            firstPlate.SetActive(true);
            TextPlate.PlayText(1);


        }
        
        if (other.tag.Equals("SecondPlate"))
        {
            firstPlate.SetActive(true);
            TextPlate.PlayText(2);
        }
        
        if (other.tag.Equals("ThirdPlate"))
        {
            firstPlate.SetActive(true);
            TextPlate.PlayText(6);
        }

    }
}
