using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoldingApples : MonoBehaviour
{
    [SerializeField] private Sprite chestClose;
    [SerializeField] private Sprite chestOpen;
    

    void Update()
    {

           
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Apples.statusChest ? chestOpen : chestClose;
    }
}


