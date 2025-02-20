using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Lista : MonoBehaviour
{

    [SerializeField] Buttons buttons;
    [SerializeField] TMP_Text text;
    [SerializeField] GameObject EKey;
    bool inTrigger = false;
    public bool lista = false;

    private void Update()
    {
        if (inTrigger && Input.GetKeyDown(KeyCode.E))
        {
            EKey.SetActive(false);
            lista = true;
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            EKey.SetActive(true);
            text.text = "Jakas lista zadan pewnie od mamy czy mam je zrobic?";
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
