using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smeirc : MonoBehaviour
{

    [SerializeField] Endings endings;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            endings.Ending_15 = true;
        }
    }

}
