using System;
using UnityEngine;
using UnityEngine.UI;

public class AppleSize : MonoBehaviour
{
    public static int appleSize; // количесво собранных яблок   
    public static int applesMaxTrening = 1; // максимальное количесво яблок в тренировке
    public static int appleMaxPlay = 5; //  максимальное количесво яблок во время игры
    private int size;
    private bool once = true; // чтобы очки сбрасывались только один раз 
    [SerializeField] public Text appleText;

    

    // Start is called before the first frame update
    void Start()
    {
        appleText = GetComponent<Text>();
        appleSize = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Apples.isTrening)
            size = applesMaxTrening;
        if (Apples.isTreningStop)
            size = appleMaxPlay;
        if (once && Apples.isTreningStop)
        {
            appleSize = 0;
            once = false;
        }
        appleText.text = appleSize + "/" + size;
        //Debug.Log(Apples.isTrening);
    }


}