using UnityEngine;
using UnityEngine.UI;

public class AppleSize : MonoBehaviour
{
    public static int appleSize; // количесво собранных яблок   
    public static int applesMaxSize = 1; // максимальное количесво яблок 
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
        appleText.text = appleSize + "/" + applesMaxSize;
    }
}