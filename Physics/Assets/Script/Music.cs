using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    // подземелье
    [SerializeField] private AudioSource[] cave;
    void Start()
    {
        cave = GetComponent<AudioSource[]>();
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log(Apples.isCave);
        if (Apples.isCave)
        {
            foreach (var i in cave)
                i.Play();
        }
        else if (!Apples.isCave)
        {
            foreach (var i in cave)
                i.Stop();
        }
    }
}
