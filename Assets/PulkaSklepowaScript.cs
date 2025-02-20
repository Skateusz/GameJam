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
            text.text = "Wzieto produkt";
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && one)
        {
            EKey.SetActive(true);
            inTrigger = true;
            text.text = "Wziac produkt z pulki???";
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
