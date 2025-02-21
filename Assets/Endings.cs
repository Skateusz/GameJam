using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Endings : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] GameObject background;
    [SerializeField] TMP_Text glownyText;
    [SerializeField] Camera cam;
    [SerializeField] TMP_Text text;
    [SerializeField] Button restart;
    public bool Ending_0 = false;
    public bool Ending_1 = false;
    public bool Ending_2 = false;
    public bool Ending_3 = false;
    public bool Ending_4 = false;
    public bool Ending_5 = false;
    public bool Ending_6 = false;
    public bool Ending_7 = false;

    private void Update()
    {
        if (Ending_0) // Jeszce musze dodac by nie mogl grac jesli ma obszczany materac
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            text.text = "Grales caly dzien rodzice zostawili ci liste rzeczy do zrobienia o ktorej nie wiedziales mimo to rodzice sa zli masz KARE";
            glownyText.text = "";
            background.SetActive(false);
        }
        if (Ending_1) 
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            text.text = "Jestes debilem pierzesz materac w pralce przez co sie niszczy masz KARE";
            glownyText.text = "";
            background.SetActive(false);
        }
        if (Ending_2)
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            text.text = "Nakryto cie na kradziezy jednak jestes za mlody by zostac ukaranym twoi rodzice ida do wiezienia!!!";
            glownyText.text = "";
            background.SetActive(false);
        }
        if (Ending_3)
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            text.text = "Nie dales bezdomnemu jedzenia, dlatego ten by je zdobyc zabija cie i je bierze NIE ZYJESZ!!!";
            glownyText.text = "";
            background.SetActive(false);
            cam.backgroundColor = Color.gray;
        }
        if (Ending_4)
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            text.text = "Wruciles do domu, rodzice sa zli bo nic nie robiles caly dzien jednak nagle przychodzi bezdomny i dziekuje ci przy rodzicach ktorzy sa z ciebie dumni NIE MASZ KARY";
            glownyText.text = "";
            background.SetActive(false);
            cam.backgroundColor = Color.gray;
        }
        if (Ending_5)
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            text.text = "Twoj ojciec nie ma pozwolenia na bron zgarnela go policja mama daje ci KARE (+ masz makowiec)";
            glownyText.text = "";
            background.SetActive(false);
            cam.backgroundColor = Color.gray;
        }
        if (Ending_6)
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            text.text = "Masz wyprany materac jednak rodzice sie o tym dowiedzieli masz KARE";
            glownyText.text = "";
            background.SetActive(false);
            cam.backgroundColor = Color.gray;
        }
        if (Ending_7)
        {
            button.gameObject.SetActive(true);
            cam.gameObject.transform.position = new Vector2(39.4f, 11.07f);
            text.text = "Okazalo sie ze pani z pralni jest bliska przyjaciulka mamy i pozwala ci wyorac u niej materac za free a na dodatek nic nie muwi rodzicom nie masz KARY";
            glownyText.text = "";
            background.SetActive(false);
            cam.backgroundColor = Color.gray;
        }
    }

}
