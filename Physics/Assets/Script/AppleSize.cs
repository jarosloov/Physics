using UnityEngine;
using UnityEngine.UI;

public class AppleSize : MonoBehaviour
{
    public static int appleSize; // количесво собранных яблок   
    public static int applesMaxSize = 1; // максимальное количесво яблок 
    public GameObject check; // галочка
    [SerializeField] public Text appleText;


    // Start is called before the first frame update
    void Start()
    {
        appleText = GetComponent<Text>();
        appleSize = 0;
        check.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        appleText.text = appleSize + "/" + applesMaxSize;

        if (appleSize >= applesMaxSize)
        {
            check.SetActive(true);
        }
    }
}