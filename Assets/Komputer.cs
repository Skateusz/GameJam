using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;

public class Komputer : MonoBehaviour
{
    [SerializeField] Lista lista;
    [SerializeField] Buttons buttons;
    [SerializeField] Endings ending;
    [SerializeField] TMP_Text text;
    [SerializeField] GameObject EKey;
    bool inTrigger = false;

    private void Update()
    {
        if(inTrigger && Input.GetKeyDown(KeyCode.E))
        {
            EKey.SetActive(false);
            ending.Ending_0 = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && buttons.wybor_01 && !lista.lista)
        {
            EKey.SetActive(true);
            if (buttons.polski) text.text = "Moge przegrac caly wolny czas na kompie";
            if (buttons.angielski) text.text = "I can lose all my free time on the computer";
            inTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && buttons.wybor_01 && !lista.lista)
        {
            EKey.SetActive(false);
            text.text = "";
            inTrigger = false;
        }
    }

}
