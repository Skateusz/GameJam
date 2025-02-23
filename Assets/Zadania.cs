using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Zadania : MonoBehaviour
{
    [SerializeField] Buttons buttons;
    [SerializeField] TMP_Text text;
    [SerializeField] Lista lista;
    [SerializeField] Zlew zlew;
    [SerializeField] Kosz kosz;
    [SerializeField] Kosz kosz_0;
    [SerializeField] Pralka pralka;
    public bool zadano = false;
    public bool wykonano = false;
    bool one = true;
    public bool one_0 = true;


    private void Update()
    {
        if (lista.lista)
        {
            Zadanie();
        }
    }

    void Zadanie()
    {
        if (one)
        {
            one = false;
            if (buttons.polski) text.text = "Umyj gary, wstaw pranie do pralki, wynies smieci";
            if (buttons.angielski) text.text = "Wash the dishes, put the laundry in the washing machine, take out the rubbish";
            zadano = true;
        }
        if (zlew.zrobiono && kosz.zrobiono && kosz_0.zrobiono && pralka.zrobiono)
        {
            if (one_0 && buttons.polski) text.text = "Brawo wykonales wszystkie zadania teraz idz na kanape i opierdzielaj sie reszte dnia!!!";
            if (one_0 && buttons.angielski) text.text = "Bravo you've done all the work, now get on the couch and slug it out for the rest of the day!!!";
            wykonano = true;
        }
    }

}
