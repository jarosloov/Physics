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
    // для чекпоинта
    [SerializeField] private GameObject checkpointFirst;
    [SerializeField] private GameObject checkpointSecond;
    [SerializeField] private GameObject player;
    
    
    void Start()
    {
        Animation anim = GetComponent<Animation>();
        slider.maxValue = maxHealth;
        slider.value = maxHealth;
        heatlth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = heatlth;
        // (!(heatlth <= 0)) return;
        if (heatlth <= 0)
        {
            if (Apples.firstCheckpoint)
            {
                player.transform.position = checkpointFirst.transform.position;
                heatlth = 100;
            }

            if (Apples.secondCheckpoint)
            {
                player.transform.position = checkpointSecond.transform.position;
            }
            heatlth = 100;
        }
       
    }

    
}
