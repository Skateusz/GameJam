using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PulkaSklepowaScript : MonoBehaviour
{

    [SerializeField] GameObject EKey;
    [SerializeField] GameObject player;
    [SerializeField] Buttons buttons;
    [SerializeField] TMP_Text text;
    bool inTrigger = false;
    public bool wzietoProduct = false;
    bool one = true;

    private void Update()
    {
        if (inTrigger && Input.GetKeyDown(KeyCode.E))
        {
            EKey.SetActive(false);
            wzietoProduct = true;
            one = false;
            if (buttons.polski) text.text = "Wzieto produkt";
            if (buttons.angielski) text.text = "The product was taken";
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && one)
        {
            EKey.SetActive(true);
            inTrigger = true;
            if (buttons.polski) text.text = "Wziac produkt z pulki???";
            if (buttons.angielski) text.text = "Take a productfrom the shellf???";
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
