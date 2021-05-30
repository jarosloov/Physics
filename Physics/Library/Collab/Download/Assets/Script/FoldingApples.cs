using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoldingApples : MonoBehaviour
{
    [SerializeField] private Sprite chestClose;
    [SerializeField] private Sprite chestOpen;

    private void Start()
    {
        
    }

    void Update()
    {
        if (Apples.statusChest)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = chestOpen;
            Debug.Log('1');
        }
            
        this.gameObject.GetComponent<SpriteRenderer>().sprite = chestClose;
    }
}


