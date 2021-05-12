using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    public GameObject door;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(AppleSize.appleSize == AppleSize.applesMaxSize)
            Destroy(door);
    }
}
