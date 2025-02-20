using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Kasjer : MonoBehaviour
{
    [SerializeField] PulkaSklepowaScript pulka;
    [SerializeField] GameObject EKey;
    [SerializeField] GameObject player;
    [SerializeField] Buttons buttons;
    [SerializeField] TMP_Text text;
    bool inTrigger = false;
    bool zaplacono = false;

    private void Update()
    {
        if (inTrigger && Input.GetKeyDown(KeyCode.E))
        {
            zaplacono = true;
            EKey.SetActive(false);
            text.text = "Zaplacono za produkt";
            pulka.wzietoProduct = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && pulka.wzietoProduct) 
        {
            EKey.SetActive(true);
            inTrigger = true;
            text.text = "Zaplacic za zakupy?";
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            EKey.SetActive(false);
            inTrigger = false;
            text.text = "";
        }
    }

}
