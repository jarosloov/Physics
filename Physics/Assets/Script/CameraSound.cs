using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSound : MonoBehaviour
{
    [SerializeField] private AudioSource fonCave; // музыка пещеры
    private bool isCaneOff;
    
    void Start()
    {
        fonCave = GetComponent<AudioSource>();
        isCaneOff = false;
    }

    void Update()
    {
        if(!Menu.isMenu)
            fonCave.Play();
        if(isCaneOff)
            fonCave.Stop();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        isCaneOff = other.GetComponent<CaveSound>();
    }
}
