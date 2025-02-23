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
            if (buttons.polski) text.text = "Niepokoi cie to ze twoj tata ma bron w domu";
            if (buttons.angielski) text.text = "Are you concerned that your dad has a gun in the house";
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
            if (buttons.polski) button_0.text = "Idz sie odlac";
            if (buttons.angielski) button_0.text = "Go take a piss";
            button1.gameObject.SetActive(true);
            if (buttons.polski) button_1.text = "Nie idz";
            if (buttons.angielski) button_1.text = "Don't go";
        }
        if(buttons.i == 1)
        {
            button0.gameObject.SetActive(true);
            if (buttons.polski) button_0.text = "Zagroz";
            if (buttons.angielski) button_0.text = "threat";
            button1.gameObject.SetActive(true);
            if (buttons.polski) button_1.text = "Daj kompa";
            if (buttons.angielski) button_1.text = "give PC";
        }
        if (buttons.i == 3)
        {
            button0.gameObject.SetActive(true);
            if (buttons.polski) button_0.text = "Wez";
            if (buttons.angielski) button_0.text = "take";
            button1.gameObject.SetActive(true);
            if (buttons.polski) button_1.text = "Zostaw";
            if (buttons.angielski) button_1.text = "leave";
        }
        if (buttons.i == 5)
        {
            button0.gameObject.SetActive(true);
            if (buttons.polski) button_0.text = "Daj jedzenie";
            if (buttons.angielski) button_0.text = "Give food";
            button1.gameObject.SetActive(true);
            if (buttons.polski) button_1.text = "Nie dawaj nic";
            if (buttons.angielski) button_1.text = "Don't give anything";
        }
        if (buttons.i == 7)
        {
            button0.gameObject.SetActive(true);
            if (buttons.polski) button_0.text = "Dzwon na policje";
            if (buttons.angielski) button_0.text = "Call the police";
            button1.gameObject.SetActive(true);
            if (buttons.polski) button_1.text = "Nic nie rob";
            if (buttons.angielski) button_1.text = "Do nothing";
        }
        if (buttons.i == 9)
        {
            button0.gameObject.SetActive(true);
            if (buttons.polski) button_0.text = "Powiedz Prawde";
            if (buttons.angielski) button_0.text = "Tell the truth";
            button1.gameObject.SetActive(true);
            if (buttons.polski) button_1.text = "Wypierz";
            if (buttons.angielski) button_1.text = "Blame it on your brother";
        }
        if (buttons.i == 11)
        {
            button0.gameObject.SetActive(true);
            if (buttons.polski) button_0.text = "Wez narkotyki";
            if (buttons.angielski) button_0.text = "Take drugs";
            button1.gameObject.SetActive(true);
            if (buttons.polski) button_1.text = "Zadzwon na policje";
            if (buttons.angielski) button_1.text = "Call the police";
        }
        if (buttons.i == 13)
        {
            button0.gameObject.SetActive(true);
            if (buttons.polski) button_0.text = "Strzel";
            if (buttons.angielski) button_0.text = "Shoot";
            button1.gameObject.SetActive(true);
            if (buttons.polski) button_1.text = "Nie strzelaj";
            if (buttons.angielski) button_1.text = "Don't shoot";
        }
        if (buttons.i == 15)
        {
            button0.gameObject.SetActive(true);
            if (buttons.polski) button_0.text = "Uciekaj";
            if (buttons.angielski) button_0.text = "Run";
            button1.gameObject.SetActive(true);
            if (buttons.polski) button_1.text = "Pozbadz sie dowodow";
            if (buttons.angielski) button_1.text = "Get rid of evidence";
        }
        if (buttons.i == 17)
        {
            button0.gameObject.SetActive(true);
            if (buttons.polski) button_0.text = "Zgodz sie";
            if (buttons.angielski) button_0.text = "Agree";
            button1.gameObject.SetActive(true);
            if (buttons.polski) button_1.text = "Odejdz";
            if (buttons.angielski) button_1.text = "Walk away";
        }
        if (buttons.i == 19)
        {
            button0.gameObject.SetActive(true);
            if (buttons.polski) button_0.text = "Wsiadz";
            if (buttons.angielski) button_0.text = "Get in";
            button1.gameObject.SetActive(true);
            if (buttons.polski) button_1.text = "Uciekaj";
            if (buttons.angielski) button_1.text = "Run";
        }
    }

}
