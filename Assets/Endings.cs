using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Endings : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] TMP_Text text;
    [SerializeField] Button restart;
    public bool Ending_0 = false;

    private void Update()
    {
        if (Ending_0) // Jeszce musze dodac by nie mogl grac jesli ma obszczany materac
        {
            cam.gameObject.transform.position = new Vector3(39.4f, 11.07f, -9);
            text.text = "Grales caly dzien rodzice zostawili ci liste rzeczy do zrobienia o ktorej nie wiedziales mimo to rodzice sa zli masz KARE";
        }
    }

}
