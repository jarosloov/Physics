using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class FallingApple : MonoBehaviour
{
    [SerializeField] private Rigidbody2D apple;
    [SerializeField] private GameObject img;
    public static bool isApple = false;
    
    [SerializeField] private GameObject video;
    [SerializeField] private VideoPlayer _videoPlayer;
    
    void Start()
    {
        apple = GetComponent<Rigidbody2D>();
        video.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isApple)
        {
            apple.bodyType  = RigidbodyType2D.Dynamic;
            StartCoroutine(PlayEND());
            StopCoroutine(PlayEND());
            video.SetActive(false);
        }
    }

    IEnumerator PlayEND()
    {
        yield return new WaitForSeconds(2f);
        video.SetActive(true);
        _videoPlayer.Play();
        yield return new WaitForSeconds(10f);
        
        _videoPlayer.Stop();
        Application.Quit();
        
    }
}
