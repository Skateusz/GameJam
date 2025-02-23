using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wyjscie : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] GameObject player;
    [SerializeField] GameObject lista;
    [SerializeField] Materac materac;
    [SerializeField] Buttons buttons;
    [SerializeField] TMP_Text text;
    [SerializeField] GameObject EKey;
    [SerializeField] GameObject materacGO;
    bool inTrigger = false;
    public int i = 0;

    private void Update()
    {
        if (inTrigger && Input.GetKeyDown(KeyCode.E))
        {
            EKey.SetActive(false);
            i = 0;
            //gameObject.SetActive(false);
            if(i == 0)
            {
                i = 1;
                player.transform.position = new Vector2(-55.1f, 57.6f);
                cam.backgroundColor = Color.green;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && (lista.activeSelf || (buttons.wybor_0) && !materacGO.activeSelf))
        {
            EKey.SetActive(true);
            if (buttons.polski) text.text = "Wyjsc na zewnatrz?";
            if (buttons.angielski) text.text = "Go outside?";
            inTrigger = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && (lista.activeSelf || (buttons.wybor_0) && !materacGO.activeSelf))
        {
            EKey.SetActive(false);
            text.text = "";
            inTrigger = false;
        }
    }

}
