using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WyboryTekst : MonoBehaviour
{
    [SerializeField] Buttons buttons;
    [SerializeField] Dialogi dialogi;
    [SerializeField] TMP_Text text;
    [SerializeField] Button button0;
    [SerializeField] Button button1;
    [SerializeField] TMP_Text button_0;
    [SerializeField] TMP_Text button_1;
    public bool mozna = false;
    bool one = false;
    private void Start()
    {
        text.text = dialogi.dialog_0[0];
    }

    private void Update()
    {
        Debug.Log("Kliknieto" + buttons.kliknieto);
        Klik();
        Klikniecie();
        Funkcja();
        if(!one && buttons.i == 7)
        {
            one = true;
            text.text = "Niepokoi cie to ze twoj tata ma bron w domu";
        }
    }

    void Klik()
    {
        if (buttons.kliknieto)
        {
            button0.gameObject.SetActive(false);
            button1.gameObject.SetActive(false);
            buttons.kliknieto = false;
        }
    }

    void Klikniecie()
    {
        if(Input.GetMouseButtonDown(0) && dialogi.i < dialogi.dialog_0.Count - 1)
        {
            if(dialogi.i != 1) dialogi.i++;
            text.text = dialogi.dialog_0[dialogi.i];
        }
    }

    void Funkcja()
    {
        if(dialogi.i == 1)
        {
            button0.gameObject.SetActive(true);
            button_0.text = "Idz sie odlac";
            button1.gameObject.SetActive(true);
            button_1.text = "Nie idz";
        }
        if(buttons.i == 1)
        {
            button0.gameObject.SetActive(true);
            button_0.text = "Zagroz";
            button1.gameObject.SetActive(true);
            button_1.text = "Daj kompa";
        }
        if (buttons.i == 3)
        {
            button0.gameObject.SetActive(true);
            button_0.text = "Wez";
            button1.gameObject.SetActive(true);
            button_1.text = "Zostaw";
        }
        if (buttons.i == 5)
        {
            button0.gameObject.SetActive(true);
            button_0.text = "Daj jedzenie";
            button1.gameObject.SetActive(true);
            button_1.text = "Nie dawaj nic";
        }
        if (buttons.i == 7)
        {
            button0.gameObject.SetActive(true);
            button_0.text = "Dzwon na policje";
            button1.gameObject.SetActive(true);
            button_1.text = "Nic nie rob";
        }
        if (buttons.i == 9)
        {
            button0.gameObject.SetActive(true);
            button_0.text = "Powiedz Prawde";
            button1.gameObject.SetActive(true);
            button_1.text = "Wypierz";
        }
    }

}
