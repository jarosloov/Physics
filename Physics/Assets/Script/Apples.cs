using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Apples : MonoBehaviour
{
    public AudioSource AppleAuduo;
    public GameObject firstPlate;
    public static bool statusChest;
    public static bool isTrening = true;
    public static bool isTreningStop = false;
    public static bool firstCheckpoint = false;
    public static bool secondCheckpoint = false;
    public static bool isCave = true;
    



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
        // шипы урон
        if (other.GetComponent<Spikes>())
        {
            HealthBar.heatlth -= 20; // урон
        }
            // чепоинт
        if (other.GetComponent<FirstCheckpoint>())
            firstCheckpoint = true;
        if (other.GetComponent<SecondCheckpoint>())
            secondCheckpoint = true;
        
        isTrening = other.GetComponent<Trening>();
        isTreningStop = other.GetComponent<StopTrening>();
        
        if (other.GetComponent<FoldingApples>())
        {
            statusChest = true;
            AppleSize.appleSize = 0;
            FallingApple.isApple = true;
        }
        else
        {
            statusChest = false;
        }
        
        // звуки пещеры
        if (other.GetComponent<Cave>())
        {
            isCave = true;
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

        
        
        //Таблички
        
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
            TextPlate.PlayText(3);
        }

        if (other.GetComponent<FourthTablichka>())
        {
            firstPlate.SetActive(true);
            TextPlate.PlayText(4);
        }

        if (other.GetComponent<FifthTablichka>())
        {
            firstPlate.SetActive(true);
            TextPlate.PlayText(5);
        }

        if (other.GetComponent<SixthTablichka>())
        {
            firstPlate.SetActive(true);
            TextPlate.PlayText(6);
        }
        if (other.GetComponent<Tablichka_Luk>())
        {
            firstPlate.SetActive(true);
            TextPlate.PlayText(7);
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag.Equals("FirstPlate") || 
            other.tag.Equals("SecondPlate") ||
            other.tag.Equals("ThirdPlate") || 
            other.GetComponent<FourthTablichka>() ||
             other.GetComponent<FifthTablichka>() || 
            other.GetComponent<SixthTablichka>() || 
             other.GetComponent<Tablichka_Luk>())
        {
            firstPlate.SetActive(false);
        }

        if (other.GetComponent<Cave>())
        {
            isCave = false;
        }
        
       /* 
        if (other.tag.Equals("SecondPlate"))
        {
            firstPlate.SetActive(false);
        }
        
        if (other.tag.Equals("ThirdPlate"))
        {
            firstPlate.SetActive(false);
        }

        if (other.GetComponent<FourthTablichka>())
        {
            firstPlate.SetActive(false);
        }

        if (other.GetComponent<FifthTablichka>())
        {
            firstPlate.SetActive(false);
        }

        if (other.GetComponent<SixthTablichka>())
        {
            firstPlate.SetActive(false);
        }
        if (other.GetComponent<Tablichka_Luk>())
        {
            firstPlate.SetActive(false);
        }
        */
       
    }
}
