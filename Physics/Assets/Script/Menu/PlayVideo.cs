using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{

    [SerializeField] private GameObject video;
    [SerializeField] private VideoPlayer _videoPlayer;
    void Update()
    {
        if (Input.GetKey(KeyCode.V))
        {
            StartCoroutine(PlayVid());
            StopCoroutine(PlayVid());
        }
    }

    private IEnumerator PlayVid()
    {
        video.SetActive(true);
        _videoPlayer.Play();
        yield return new WaitForSeconds(24);
        _videoPlayer.Stop();
        video.SetActive(false);
        
    }
}
