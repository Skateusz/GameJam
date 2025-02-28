using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SzafkaRodzicow : MonoBehaviour
{
    [SerializeField] GameObject lista;
    [SerializeField] Buttons buttons;
    [SerializeField] TMP_Text text;
    [SerializeField] GameObject EKey;
    bool inTrigger = false;
    public int i = 0;

    private void Update()
    {
        if (inTrigger && Input.GetKeyDown(KeyCode.E))
        {
            EKey.SetActive(false);
            if (i == 0)
            {
                if (buttons.polski) text.text = "Znalazles pistolet";
                if (buttons.angielski) text.text = "You found a gun";
                buttons.i = 3;
            }
            if (i == 1) text.text = "";
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && i == 0 && !buttons.wybor_0 && lista.activeSelf)
        {
            EKey.SetActive(true);
            if (buttons.polski) text.text = "Przeszukac?";
            if (buttons.angielski) text.text = "Search?";
            inTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && i == 0 && !buttons.wybor_0 && lista.activeSelf)
        {
            EKey.SetActive(false);
            text.text = "";
            inTrigger = false;
        }
    }

}
