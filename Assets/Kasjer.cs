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
    public bool zaplacono = false;

    private void Update()
    {
        if (inTrigger && Input.GetKeyDown(KeyCode.E))
        {
            zaplacono = true;
            EKey.SetActive(false);
            if (buttons.polski) text.text = "Zaplacono za produkt";
            if (buttons.angielski) text.text = "Paid for product";
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && pulka.wzietoProduct && !zaplacono) 
        {
            EKey.SetActive(true);
            inTrigger = true;
            if (buttons.polski) text.text = "Zaplacic za zakupy?";
            if (buttons.angielski) text.text = "Pay for your shopping?";
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
