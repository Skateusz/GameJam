using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Kobieta : MonoBehaviour
{

    [SerializeField] TMP_Text text;
    [SerializeField] Buttons buttons;
    [SerializeField] GameObject EKey;
    bool inTrigger = false;

    private void Update()
    {
        if (inTrigger && Input.GetKeyDown(KeyCode.E))
        {
            EKey.SetActive(false);
            buttons.i = 9;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            EKey.SetActive(true);
            text.text = "Chcesz wyprac materac?";
            inTrigger = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            EKey.SetActive(false);
            text.text = "";
            inTrigger = false;
        }
    }

}
