using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class MenuLanguage : MonoBehaviour
{
    [SerializeField] public Text _language1, _language2, _play,_settings1,_settings2, 
        _exit, _comeBack1,  _comeBack2, _audio, _authors, _controlling;
    [SerializeField] private static Text language1, language2, play,settings1,settings2,
        exit, comeBack1, comeBack2, audio, authors, controlling;

    private void Start()
    {
        language1 = _language1;
        language2 = _language2;
        play = _play;
        settings1 = _settings1;
        settings2 = _settings2;
        exit = _exit;
        comeBack1 = _comeBack1;
        comeBack2 = _comeBack2;
        audio = _audio;
        authors = _authors;
        controlling = _controlling;
    }

    public static void Russian()
    {
        language1.text = "Язык";
        language2.text = "< Язык >";
        play.text = "Играть";
        settings1.text = "Настройки";
        settings2.text = "< Настройки >";
        exit.text = "Выход";
        comeBack1.text = "вернуться назад";
        comeBack2.text = "вернуться назад";
        audio.text = "звук";
        authors.text = "авторы";
        controlling.text = "управление";
    }

    public static void English()
    {
        language1.text = "language";
        language2.text = "< language >";
        play.text = "Play";
        settings1.text = "Settings";
        settings2.text = "< Settings >";
        exit.text = "Exit";
        comeBack1.text = "come back";
        comeBack2.text = "come back";
        audio.text = "audio";
        authors.text = "authors";
        controlling.text = "controlling";
    }
}
