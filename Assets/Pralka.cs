using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pralka : MonoBehaviour
{
    [SerializeField] Endings endings;
    [SerializeField] Materac materac;
    [SerializeField] Buttons buttons;
    [SerializeField] TMP_Text text;
    [SerializeField] GameObject EKey;
    bool inTrigger = false;

    private void Update()
    {
        if (inTrigger && Input.GetKeyDown(KeyCode.E))
        {
            endings.Ending_1 = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && materac.materac)
        {
            EKey.SetActive(true);
            text.text = "Moge wyprac materac w pralce";
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
    }

}
