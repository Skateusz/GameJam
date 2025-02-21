using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Wyjscie_2 : MonoBehaviour
{
    [SerializeField] GameObject menel;
    [SerializeField] Endings endings;
    [SerializeField] Kasjer kasjer;
    [SerializeField] PulkaSklepowaScript pulka;
    [SerializeField] GameObject EKey;
    [SerializeField] GameObject player;
    [SerializeField] Buttons buttons;
    [SerializeField] TMP_Text text;
    bool inTrigger = false;
    public bool kupil = false;
    public bool wyszedl = false;

    private void Update()
    {
        if(inTrigger && Input.GetKeyDown(KeyCode.E) && !pulka.wzietoProduct)
        {
            EKey.SetActive(false);
            player.transform.position = new Vector2(-76.29f, 55.01f);
            wyszedl = true;
        }
        if (inTrigger && Input.GetKeyDown(KeyCode.E) && pulka.wzietoProduct && !kasjer.zaplacono)
        {
            EKey.SetActive(false);
            endings.Ending_2 = true;
            wyszedl = true;
        }
        if (inTrigger && Input.GetKeyDown(KeyCode.E) && pulka.wzietoProduct && kasjer.zaplacono)
        {
            EKey.SetActive(false);
            player.transform.position = new Vector2(-76.29f, 55.01f);
            kupil = true;
            menel.gameObject.SetActive(true);
            wyszedl = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && !pulka.wzietoProduct) //Nic nie wzial
        {
            EKey.SetActive(true);
            inTrigger = true;
            text.text = "Wyjsc?";
        }
        if (collision.collider.CompareTag("Player") && pulka.wzietoProduct && !kasjer.zaplacono) //Kradziez
        {
            EKey.SetActive(true);
            inTrigger = true;
            text.text = "Wyjsc?";
        }
        if (collision.collider.CompareTag("Player") && pulka.wzietoProduct && kasjer.zaplacono) //Zaplacil
        {
            EKey.SetActive(true);
            inTrigger = true;
            text.text = "Wyjsc?";
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && !wyszedl)
        {
            EKey.SetActive(false);
            inTrigger = false;
            text.text = "";
        }
    }

}
