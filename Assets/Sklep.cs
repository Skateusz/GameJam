using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sklep : MonoBehaviour
{
    [SerializeField] GameObject EKey;
    [SerializeField] GameObject player;
    [SerializeField] Buttons buttons;
    [SerializeField] TMP_Text text;
    bool inTrigger = false;

    private void Update()
    {
        if(inTrigger && Input.GetKeyDown(KeyCode.E))
        {
            player.transform.position = new Vector2(-68.56f, 1.11f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && !buttons.wybor_0)
        {
            EKey.SetActive(true);
            inTrigger = true;
            if (buttons.polski) text.text = "Moge wejsc do sklepu";
            if (buttons.angielski) text.text = "I can go to shop";
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && !buttons.wybor_0)
        {
            EKey.SetActive(false);
            inTrigger = false;
            text.text = "";
        }
    }

}
