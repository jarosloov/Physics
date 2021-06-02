using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject planePause;
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject video;
    private bool isPause = false;
    void Start()
    {
        planePause.SetActive(isPause);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPause = !isPause;
            planePause.SetActive(isPause);
        }
    }

    public void ReturnMenu()
    {
        planePause.SetActive(false);
        menu.SetActive(true);
        video.SetActive(true);
    }
}
