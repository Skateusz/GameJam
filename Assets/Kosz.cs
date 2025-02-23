using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Kosz : MonoBehaviour
{
    [SerializeField] Buttons buttons;
    [SerializeField] Zadania zadania;
    [SerializeField] TMP_Text text;
    [SerializeField] GameObject EKey;
    bool inTrigger = false;
    public bool zrobiono = false;

    private void Update()
    {
        if(inTrigger && Input.GetKeyDown(KeyCode.E) && !zrobiono)
        {
            EKey.SetActive(false);
            zrobiono = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && zadania.zadano && !zrobiono)
        {
            if (buttons.polski) text.text = "Oproznic kosz?";
             if (buttons.angielski) text.text = "Empty the bin?";
            EKey.SetActive(true);
            inTrigger = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            text.text = "";
            EKey.SetActive(false);
            inTrigger = false;
        }
    }

}
