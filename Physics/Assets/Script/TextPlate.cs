using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPlate : MonoBehaviour
{
    [SerializeField] public static Text plate;
    private static string firstTablichka;
    private static string secondTablichka;
    private static string tablichka_Luk;
    private static string thirdTablichka;
    private static string fourthTablichka;
    private static string fifthTablichka;
    private static string sixthTablichka;



    void Start()
    {
        plate = GetComponent<Text>();
        firstTablichka = "Так, кажется я куда-то попал... Чтож пойдем вперед... 'A S D'";
        tablichka_Luk = "Чтобы открыть дверь, нажмите 'Q'...  Но там... ";
        secondTablichka = "Jump ну или прыжок... 'spase'";
        thirdTablichka = "Я должен найти Ньютона. Яблочки мне пригодятся)";
        fourthTablichka = "Начнем... ";
        fifthTablichka = "Похоже, что дальше пути нет... Но аномалии всё ещё действуют. 'ПКМ' ";
        sixthTablichka = "Сейчас главное не трогать камни...";
    }

    public static void PlayText(int num)
    {
        plate.text = num switch
        {
            1 => firstTablichka,
            2 => secondTablichka,
            3 => thirdTablichka,
            4 => fourthTablichka,
            5 => fifthTablichka,
            6 => sixthTablichka,
            7 => tablichka_Luk,
            _ => plate.text
        };
    }
    
}
