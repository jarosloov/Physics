using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBall : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject gObj;
    public static bool statusRB = false;
    public static  float domage = 20;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gObj = GetComponent<GameObject>();
    }
    void Update()
    {
        if (statusRB)
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            StartCoroutine(Falling());
            StopCoroutine(Falling());
        }

    }
    
    IEnumerator Falling()
    {
        yield return new WaitForSeconds(7f);
        Destroy(gameObject);
    }
}
