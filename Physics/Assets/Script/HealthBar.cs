using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public float maxHealth = 100f; // максимальное количесво здоровья
    public static float heatlth; // текущее здоровье 
    
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
        if(heatlth <=0)
            SceneManager.LoadScene(1);
    }
}
