using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDoorsScript : MonoBehaviour
{

    [SerializeField] GameObject[] EKey;
    public bool Pokoj_01 = false;

    private void Update()
    {
        if (Pokoj_01 && Input.GetKeyDown(KeyCode.E)) 
        {
            EKey[0].SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // Collider2D other
    {
        if (collision.collider.CompareTag("RoomDoor"))
        {
            EKey[0].SetActive(true);
            Pokoj_01 = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("RoomDoor"))
        {
            EKey[0].SetActive(false);
            Pokoj_01 = false;
        }
    }

}
