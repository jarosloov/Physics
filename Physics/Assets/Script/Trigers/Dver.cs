using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Dver : MonoBehaviour
{
    [SerializeField] private Sprite doorСontour;
    [SerializeField] private Sprite doorNoContour;
    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = doorNoContour;
    }
    
    void Update()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = PlayVideo.isTriger ? doorСontour : doorNoContour;
    }
}
