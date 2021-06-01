using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    [SerializeField] private  GameObject doorTrening;
    [SerializeField] private GameObject doorUp;
    void Update()
    {
        // для тренеровки
        if(AppleSize.appleSize >= AppleSize.applesMaxTrening)
            Destroy(doorTrening);
        
        if(AppleSize.appleSize >= AppleSize.appleMaxPlay)
            Destroy(doorUp);
        
    }
}
