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
    public Animator animator;
    
    [SerializeField] private GameObject menu;
    
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
        if (heatlth + 1 <= 0)
        {
            StartCoroutine(Die());
            StopCoroutine(Die());
        }
            
    }

    IEnumerator Die()
    {
        animator.Play("Die");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(0);
        menu.SetActive(false);
    }
    
}
