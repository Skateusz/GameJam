using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pralnia : MonoBehaviour
{

    [SerializeField] GameObject player;
    [SerializeField] GameObject EKey;
    bool inTrigger = false;

    private void Update()
    {
        if (inTrigger && Input.GetKeyDown(KeyCode.E))
        {
            EKey.SetActive(false);
            player.transform.position = new Vector2(-76.44f, 112.12f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            EKey.SetActive(true);
            inTrigger = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            EKey.SetActive(false);
            inTrigger = false;
        }
    }

}
