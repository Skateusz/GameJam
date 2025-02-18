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
    private void Start()
    {
        text.text = dialogi.dialog_0[0];
    }

    private void Update()
    {
        Debug.Log(dialogi.i);
        Klik();
        Klikniecie();
        Funkcja();
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
        if(Input.GetMouseButtonDown(0) && dialogi.i < dialogi.dialog_0.Count)
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
    }

}
