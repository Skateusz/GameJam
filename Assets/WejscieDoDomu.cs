using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WejscieDoDomu : MonoBehaviour
{

    [SerializeField] Camera cam;
    [SerializeField] Endings endings;
    [SerializeField] Buttons buttons;
    [SerializeField] GameObject player;
    [SerializeField] GameObject EKey;
    bool inTrigger = false;

    private void Update()
    {
        if(inTrigger && Input.GetKeyDown(KeyCode.E))
        {
            player.transform.position = new Vector2(-18.7f, -12.63f);
            cam.backgroundColor = Color.gray;
        }
        if (inTrigger && Input.GetKeyDown(KeyCode.E) && buttons.wybor_03)
        {
            endings.Ending_4 = true;   
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
