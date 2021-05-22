using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public static bool gravity = true;
    public bool top;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _rigidbody2D.gravityScale *= -1 ;
            gravity = !gravity;
            /**
            if (!gravity)
            {
                _rigidbody2D.gravityScale = 1;
                gravity = true;
            }
            
            if (gravity) // если гравитация сущесвует, то отключить её 
            {
                _rigidbody2D.gravityScale = -1;
                gravity = false;
            }
            **/


            Rotate();
        }
        
    }
    
    
    void Rotate()
    {
        transform.eulerAngles = top == false ? new Vector3(0, 0, 180) : Vector3.zero;

        top = !top;
    }
}
