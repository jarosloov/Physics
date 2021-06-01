using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject planePause;
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
            if (isPause)
                Time.timeScale = 0;
            if(!isPause)
                Time.timeScale = 1;
            planePause.SetActive(isPause);
        }
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }
}
