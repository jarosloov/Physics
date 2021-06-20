using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{

    [SerializeField] private GameObject video;
    [SerializeField] private VideoPlayer _videoPlayer;

    public static bool isPlay = true;

    public static bool isTriger;
    
    private void Start()
    {
        video.SetActive(false);
        isTriger = false;
        
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Q) && isTriger && isPlay)
        {
            StartCoroutine(PlayVid());
            StopCoroutine(PlayVid());
            isPlay = false;
            
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        isTriger = other.GetComponent<Dver>();
    }

    private IEnumerator PlayVid()
    {
        video.SetActive(true);
        _videoPlayer.Play();
        yield return new WaitForSeconds(40);
        _videoPlayer.Stop();
        video.SetActive(false);
    }
}
