using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject settings;
    [SerializeField] private GameObject language;
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject video;

    [SerializeField] private GameObject player;
    [SerializeField] private AudioSource fonAudioSource;

    public static  bool isMenu;
    //[SerializeField] private Text lang;

    private void Start()
    {
        fonAudioSource = GetComponent<AudioSource>();
        settings.SetActive(false);
        language.SetActive(false);
        menu.SetActive(true);
        video.SetActive(true);
        player.transform.position = new Vector3(-10, -1 , 0);
        
    }

    private void Update()
    {
        if(!isMenu)
            fonAudioSource.Stop();
        
    }

    public void Settings()
    {
        settings.SetActive(true);
        menu.SetActive(false);
    }

    public void MainMenu()
    {
        settings.SetActive(false);
        language.SetActive(false);
        menu.SetActive(true);
    }

    public void Play()
    {
        isMenu = false;
        menu.SetActive(false);
        video.SetActive(false);
        player.transform.position = new Vector3(-10, -1 , 0);

    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Language()
    {
        language.SetActive(true);
        menu.SetActive(false);
        settings.SetActive(false);
    }

    public void VariantLanguage(int numer)
    {
        switch (numer)
        {
            case 0:
                MenuLanguage.Russian();
                break;
            case 1:
                MenuLanguage.English();
                break;
        }
    }
}
