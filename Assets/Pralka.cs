using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pralka : MonoBehaviour
{

    [SerializeField] Zadania zadania;
    [SerializeField] Endings endings;
    [SerializeField] Materac materac;
    [SerializeField] Buttons buttons;
    [SerializeField] TMP_Text text;
    [SerializeField] GameObject EKey;
    bool inTrigger = false;
    public bool zrobiono = false;

    private void Update()
    {
        if (inTrigger && Input.GetKeyDown(KeyCode.E) && materac.materac)
        {
            endings.Ending_1 = true;
        }
        if (inTrigger && Input.GetKeyDown(KeyCode.E) && zadania.zadano && !zrobiono)
        {
            EKey.SetActive(false);
            zrobiono = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && materac.materac)
        {
            EKey.SetActive(true);
            if (buttons.polski) text.text = "Moge wyprac materac w pralce";
            if (buttons.angielski) text.text = "I can wash the mattress in the washing machine";
            inTrigger = true;
        }
        if (collision.collider.CompareTag("Player") && zadania.zadano && !zrobiono)
        {
            EKey.SetActive(true);
            if (buttons.polski) text.text = "Wstawic pranie";
            if (buttons.angielski) text.text = "Put the laundry in";
            inTrigger = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && materac.materac)
        {
            EKey.SetActive(false);
            text.text = "";
            inTrigger = false;
        }
        if (collision.collider.CompareTag("Player") && zadania.zadano)
        {
            EKey.SetActive(false);
            text.text = "";
            inTrigger = false;
        }
    }

}
