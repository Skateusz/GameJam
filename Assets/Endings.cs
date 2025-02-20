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
    }

}
