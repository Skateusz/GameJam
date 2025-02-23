using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Kanapa : MonoBehaviour
{
    [SerializeField] Buttons buttons;
    [SerializeField] Zadania zadania;
    [SerializeField] TMP_Text text;
    [SerializeField] GameObject EKey;
    [SerializeField] Endings endings;
    bool inTrigger = false;

    private void Update()
    {
        if (inTrigger && Input.GetKeyDown(KeyCode.E))
        {
            EKey.SetActive(false);
            endings.Ending_8 = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && zadania.wykonano)
        {
            if (buttons.polski) text.text = "Opierdzielac sie?";
            if (buttons.angielski) text.text = "Rest?";
            EKey.SetActive(true);
            inTrigger = true;
            zadania.one_0 = false;
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
