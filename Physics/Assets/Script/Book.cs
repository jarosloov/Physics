using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Book : MonoBehaviour
{
    [SerializeField] public GameObject book;
    private bool statusBook = false;
    
        
    void Start()
    {
        book.SetActive(statusBook);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            statusBook = !statusBook;
            if(statusBook)
                Time.timeScale = 0;
            if(!statusBook)
                Time.timeScale = 1;
            book.SetActive(statusBook);
            
        }
    }
}
