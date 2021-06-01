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

    [SerializeField] private Text lang;

    private void Start()
    {
        settings.SetActive(false);
        language.SetActive(false);
        menu.SetActive(true);
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
        SceneManager.LoadScene(1);
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
