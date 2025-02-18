using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;

public class Komputer : MonoBehaviour
{
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
        if (other.CompareTag("Player"))
        {
            EKey.SetActive(true);
            text.text = "Moge przegrac caly wolny czas na kompie";
            inTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            EKey.SetActive(false);
            text.text = "";
            inTrigger = false;
        }
    }

}
