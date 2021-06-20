using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show : MonoBehaviour
{
    [SerializeField] private Sprite sword;
    [SerializeField] private Sprite newSword;
   
    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = sword;
    }

    
    void Update()
    {
        if(!PlayVideo.isPlay)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = newSword;
    }
}
