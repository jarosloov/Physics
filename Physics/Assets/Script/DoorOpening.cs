using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    [SerializeField] private  GameObject door;
    void Update()
    {
        if(AppleSize.appleSize >= AppleSize.applesMaxSize)
            Destroy(door);
    }
}
