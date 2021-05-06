using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public float maxHealth = 100f;
    public static float heatlth;
    
    void Start()
    {
        slider.maxValue = maxHealth;
        slider.value = maxHealth;
        heatlth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = heatlth;
    }
}
