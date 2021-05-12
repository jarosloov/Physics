using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPlate : MonoBehaviour
{
    [SerializeField] public static Text plate;
    public static string[] textPlat = new string[]
    {
        "Привет, странник ты попал куда то ...",
        "Упрвление на  W S D A",
        "Высоко... Да?",
        "Как говорил один мудрец: присядь и ... ",
        "Что дальше не помню... ",
        "А точно нажми пробел..",
        "Собирай яблички.. ",
        "Они не только вкусн-ные но и помогут тебе совершить важное дело.."
    };
    void Start()
    {
        plate = GetComponent<Text>();
        
    }

    public static void PlayText(int num)
    {
        plate.text = textPlat[num];
    }
}
